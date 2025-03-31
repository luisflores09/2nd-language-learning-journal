// Print "Hello World!" with a newline at the end
Console.WriteLine("Hello World!");

// Print "Hello " without a newline
Console.Write("Hello ");

// Print "World!" without a newline
Console.Write("World!");
Console.WriteLine("");

// Declare and initialize variables
int myInt = 42; // Integer type
double myDouble = 3.14; // Double-precision floating-point type
char myChar = 'A'; // Character type
string myString = "C# is fun!"; // String type
bool myBool = true; // Boolean type

// Print the variables
Console.WriteLine("Integer: " + myInt);
Console.WriteLine("Double: " + myDouble);
Console.WriteLine("Character: " + myChar);
Console.WriteLine("String: " + myString);
Console.WriteLine("Boolean: " + myBool);

// Example of an array
int[] myArray = { 1, 2, 3, 4, 5 };
Console.WriteLine("Array element at index 2: " + myArray[2]);

// Example of a conditional statement
if (myBool)
{
    Console.WriteLine("The boolean value is true.");
}
else
{
    Console.WriteLine("The boolean value is false.");
}

// Example of a loop
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine("Array element at index " + i + ": " + myArray[i]);
}

// Example of a constant
const double Pi = 3.14159; // Constant value cannot be changed
Console.WriteLine("Constant Pi: " + Pi);

// Example of different data types
byte myByte = 255; // 8-bit unsigned integer
short myShort = -32768; // 16-bit signed integer
long myLong = 9223372036854775807; // 64-bit signed integer
float myFloat = 3.14f; // Single-precision floating-point type
decimal myDecimal = 19.99m; // High-precision decimal type

// Print the variables
Console.WriteLine("Byte: " + myByte);
Console.WriteLine("Short: " + myShort);
Console.WriteLine("Long: " + myLong);
Console.WriteLine("Float: " + myFloat);
Console.WriteLine("Decimal: " + myDecimal);


// Single-dimensional array example
int[] singleArray = { 10, 20, 30, 40, 50 };
Console.WriteLine("Single-dimensional array:");
foreach (int item in singleArray)
{
    Console.WriteLine(item);
}

// Accessing and modifying elements
singleArray[2] = 35; // Modify the third element
Console.WriteLine("Modified element at index 2: " + singleArray[2]);

// Useful methods for single-dimensional arrays
Console.WriteLine("Length of singleArray: " + singleArray.Length);
Array.Sort(singleArray); // Sort the array
Console.WriteLine("Sorted singleArray:");
foreach (int item in singleArray)
{
    Console.WriteLine(item);
}

// Multi-dimensional array example
int[,] multiArray = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
Console.WriteLine("Multi-dimensional array:");
for (int i = 0; i < multiArray.GetLength(0); i++)
{
    for (int j = 0; j < multiArray.GetLength(1); j++)
    {
        Console.Write(multiArray[i, j] + " ");
    }
    Console.WriteLine();
}

// Accessing and modifying elements
multiArray[1, 1] = 55; // Modify the element at row 1, column 1
Console.WriteLine("Modified element at (1, 1): " + multiArray[1, 1]);

// Useful methods for multi-dimensional arrays
Console.WriteLine("Number of rows: " + multiArray.GetLength(0));
Console.WriteLine("Number of columns: " + multiArray.GetLength(1));

Console.WriteLine("<-------------------->");

Console.WriteLine("Welcome to the Name Badge Generator!");

// Prompt user for their name
Console.Write("Enter your name: ");
string name = Console.ReadLine();

// Prompt user for their job
Console.Write("Enter your job title: ");
string job = Console.ReadLine();

// Prompt user for their contact information
Console.Write("Enter your contact information: ");
string contactInfo = Console.ReadLine();

// Generate and display the name badge
Console.WriteLine("\n<--- Name Badge --->");
Console.WriteLine("Name: " + name);
Console.WriteLine("Job Title: " + job);
Console.WriteLine("Contact Info: " + contactInfo);
Console.WriteLine("<------------------->");