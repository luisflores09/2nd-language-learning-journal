Console.WriteLine("<---------Exploring .NET Class Library---------->");
Console.WriteLine("Hello, World!");

// Example of using System.Math namespace
double number = 16;
double squareRoot = Math.Sqrt(number);
Console.WriteLine($"The square root of {number} is {squareRoot}");

// Example of using System.Text namespace
var stringBuilder = new System.Text.StringBuilder();
stringBuilder.Append("Hello, ");
stringBuilder.Append(".NET Class Library!");
Console.WriteLine(stringBuilder.ToString());

// Example of using System namespace
DateTime now = DateTime.Now;
Console.WriteLine($"Current Date and Time: {now}");

// Example of using System.IO namespace
string filePath = "example.txt"; // Specify the file path
string contentToWrite = "This is an example of writing text to a file using File.WriteAllText.";

// Write the content to the file
File.WriteAllText(filePath, contentToWrite);
Console.WriteLine($"Content written to file: {filePath}");

// Read the content back to verify
string fileContent = File.ReadAllText(filePath);
Console.WriteLine($"Content read from file: {fileContent}");

// Example of using System.Collections.Generic namespace
List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
fruits.Add("Date");
Console.WriteLine("Fruits List:");
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}

// Example of using System.Threading namespace
Console.WriteLine("Starting a new thread...");
Thread thread = new Thread(() =>
{
    Thread.Sleep(1000); // Simulate work
    Console.WriteLine("Thread completed!");
});
thread.Start();
thread.Join();

Console.WriteLine("<---------Using Classes and Interfaces from .NET Class Library---------->");

// Example of using the IDisposable interface
using (var fileStream = new System.IO.FileStream("example.txt", System.IO.FileMode.OpenOrCreate))
{
    byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, FileStream!");
    fileStream.Write(data, 0, data.Length);
    Console.WriteLine("Data written to file using FileStream.");
}

// Example of using the IEquatable interface
var point1 = new System.Drawing.Point(10, 20);
var point2 = new System.Drawing.Point(10, 20);
Console.WriteLine($"Are points equal? {point1.Equals(point2)}");

Console.WriteLine("<------------------->");

Console.WriteLine("<---------Using Classes and Interfaces from .NET Class Library---------->");

// Example of using the IDisposable interface
using (var memoryStream = new System.IO.MemoryStream())
{
    byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, MemoryStream!");
    memoryStream.Write(data, 0, data.Length);
    memoryStream.Position = 0;

    using (var reader = new System.IO.StreamReader(memoryStream))
    {
        Console.WriteLine($"Read from MemoryStream: {reader.ReadToEnd()}");
    }
}

// Example of using the IComparable interface
List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };
numbers.Sort(); // IComparable is implemented by int
Console.WriteLine("Sorted Numbers:");
foreach (var num in numbers)
{
    Console.WriteLine(num);
}

// Example of using the IEnumerable interface
IEnumerable<string> enumerableFruits = new List<string> { "Apple", "Banana", "Cherry" };
Console.WriteLine("Fruits from IEnumerable:");
foreach (var fruit in enumerableFruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("<------------------->");