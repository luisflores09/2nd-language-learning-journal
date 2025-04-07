using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ITaskService>(new InMemoryTaskService());
var app = builder.Build();

var todos = new List<Todo>();

app.UseRewriter(new RewriteOptions().AddRedirect("tasks/(.*)", "todos/$1"));
app.Use(async (context, next) =>
{
    Console.WriteLine($"[{context.Request.Method}, {context.Request.Path}, {DateTime.UtcNow}] Started.");
    await next(context);
    Console.WriteLine($"[{context.Request.Method}, {context.Request.Path}, {DateTime.UtcNow}] Finished.]");
});

app.MapGet("/todos", (ITaskService service) => service.GetAllTodos());

app.MapGet("/todos/{id}", Results<Ok<Todo>, NotFound> (int id, ITaskService service) =>
{
    var targetTodo = service.GetTodoById(id);
    return targetTodo is null
    ? TypedResults.NotFound()
    : TypedResults.Ok(targetTodo);
});

app.MapPost("/todos", (Todo task, ITaskService service) =>
{
    service.AddTodo(task);
    return TypedResults.Created("/todos/{id}", task);
})
.AddEndpointFilter(async (context, next) =>
{
    var taskArgument = context.GetArgument<Todo>(0);
    var errors = new Dictionary<string, string[]>();
    if (taskArgument.DueDate < DateTime.UtcNow)
    {
        errors.Add(nameof(Todo.DueDate), new[] { "Due date must be in the future." });
    }
    if (taskArgument.IsCompleted)
    {
        errors.Add(nameof(Todo.IsCompleted), ["Task must not be completed."]);
    }
    if (errors.Count > 0)
    {
        return TypedResults.ValidationProblem(errors);
    }
    else
    {
        return await next(context);
    }
});

app.MapDelete("/todos/{id}", (int id, ITaskService service) =>
{
    service.DeleteTodoById(id);
    return TypedResults.NoContent();
});

app.Run();

public record Todo(int Id, string Name, DateTime DueDate, bool IsCompleted);

interface ITaskService
{
    Todo? GetTodoById(int id);
    List<Todo> GetAllTodos();
    void DeleteTodoById(int id);
    Todo AddTodo(Todo task);
}

class InMemoryTaskService : ITaskService
{
    private readonly List<Todo> _todos = [];
    public Todo AddTodo(Todo task)
    {
        _todos.Add(task);
        return task;
    }
    public void DeleteTodoById(int id)
    {
        _todos.RemoveAll(task => id == task.Id);
    }

    public List<Todo> GetAllTodos()
    {
        return _todos;
    }

    public Todo? GetTodoById(int id)
    {
        return _todos.SingleOrDefault(task => id == task.Id);
    }
};