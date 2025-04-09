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
int myInt32 = 2147483647; // 32-bit signed integer
long myLong = 9223372036854775807; // 64-bit signed integer
float myFloat = 3.14f; // Single-precision floating-point type
decimal myDecimal = 19.99m; // High-precision decimal type

// Print the variables
Console.WriteLine("Byte: " + myByte);
Console.WriteLine("Short: " + myShort);
Console.WriteLine("Int32: " + myInt32);
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

// Example of string interpolation
string fristFriend = "     Maria     "; // Declare a string with leading and trailing spaces
string secondFriend = "     Scott     "; // Declare another string with spaces
fristFriend = fristFriend.Trim(); // Remove leading and trailing spaces from the first string

// Use string interpolation to combine the trimmed strings into a sentence
string friends = $"My friends are {fristFriend} and {secondFriend.Trim()}.";

Console.WriteLine(friends); // Print the sentence with the friends' names
Console.WriteLine(friends.Replace("Scott", "Anthony")); // Replace "Scott" with "Anthony" and print the updated sentence

// Nested loop example to generate cell coordinates
for (int row = 1; row < 11; row++) // Outer loop for rows (1 to 10)
{
    for (char column = 'a'; column < 'k'; column++) // Inner loop for columns ('a' to 'j')
    {
        // Print the cell coordinates in the format (row, column)
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}

Console.WriteLine("<---------Cup<T>---------->");

// Create a list of names
var names = new List<string> { "Alice", "Bob", "Charlie" };

names.Add("Frank"); // Add a new name to the list
names.Add("Zack"); // Add a new name to the list
names.Add("Tom"); // Add a new name to the list

// Iterate through each name in the list
foreach (var nameValue in names)
{
    // Print a greeting with the name in uppercase
    Console.WriteLine($"Hello {nameValue.ToUpper()}!");
}

Console.WriteLine(names[0]); // Print the first name in the list
Console.WriteLine(names[names.Count - 1]); // Print the last name in the list
Console.WriteLine(names[^1]); // Print the last name in the list using the index from the end
Console.WriteLine(names[0..2]); // Print the first two names in the list using range syntax
Console.WriteLine(names[1..^1]); // Print the names from index 1 to the second-to-last name using range syntax
Console.WriteLine(names[1..]); // Print all names starting from index 1 using range syntax
Console.WriteLine(names[..^1]); // Print all names except the last one using range syntax

Console.WriteLine("<------------------->");

Console.WriteLine("<---------Sorting and Searching Lists---------->");
names.Sort(); // Sort the list of names in ascending order
foreach (var nameValue in names)
{
    // Print a greeting with the name in uppercase
    Console.WriteLine($"{name}");
}
Console.WriteLine("<------------------->");