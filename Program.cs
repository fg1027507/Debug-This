// Debug This! 
// Your job: find and fix the bugs and add defensive programming

// Even though we are writing top-level code, we still need two "using" statements; enter them below
// changed consoleWriteLine to Console.WriteLine
using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to the Debugging Challenge!");
// change Console.Write to Console.WriteLine
Console.WriteLine("Enter your name: ");
// added Console.Write(">> ") for readability
Console.Write(">> ");
// Added a null coalescing operator to prevent a null input
// Adding a do while loop to allow for re-entry of name
string name;
do
{
    name = Console.ReadLine() ?? "Guest";
    // Added a check for empty or whitespace names
    if (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Name cannot be empty. Setting name to 'Guest'.");
        name = "Guest";
    }
    Console.WriteLine($"[DeBug]: Name = {name}");
} while (false);
//Rewriten with a formate string for readablility
Console.WriteLine($"Hello {name}! Let's do some math.");
Console.WriteLine("Enter a number: ");
// added Console.Write(">> ") for readability
Console.Write(">> ");
//using TryParse so it can 
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Invalid input! Please enter a whole number: ");
}
// Added a debug line to show the number input
Console.WriteLine($"[DeBug]: Number = {number}");
try
{
    int result = 100 / number;
    // For Debugging purposes
    Console.WriteLine($"[DeBug]: Result = {result}");
    Console.WriteLine($"100 divided by your number is: {result}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("// CATCH: Unexpected divide by zero occurred.");
}

try
{
    int remainder = 100 % number;
    // For Debugging purposes
    Console.WriteLine($"[DeBug]: Remainder = {remainder}");
    Console.WriteLine($"The remainder of 100 divided by your number is: {remainder}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("// CATCH: Unexpected divide by zero while computing remainder.");
}

// changed = to ==
if (number == 10)
{
    Console.WriteLine("You entered ten!");
}
// changed els to else
else
{
    Console.WriteLine("You didn’t enter ten.");
}

int counter = 0;
while (counter < number)
{
    //Rewriten with a formate string for readablility
    Console.WriteLine($"Counting up: {counter}");
    // changed to counter++ from counter--
    counter++;
}
Console.WriteLine("Done counting!");

string again;
// Switched the while and do
do
{
    Console.WriteLine("Do you want to see your number squared? (yes/no)");
    // Added a lower oporator to avoid the wrong formate
    // Added a null coalescing operator to prevent a null input
    again = Console.ReadLine() ??  "" .ToLower();
    // Rewriten this line with formate strings
    Console.WriteLine($"Your number squared is: {number * number}");
}
while (again == "yes"); // There are two fixes to make to this line


for (int i = 5; i >= 0; i--) // Check this line
{
    Console.WriteLine($"Countdown: {i}");
}

int[] scores = new int[5];
scores[0] = 100; // Check this line
// Rewriten this line with formate string
Console.WriteLine($"First score: {scores[0]}");
//Rewriten with a formate string for readablility
// Changed 4 to scores.Length - 1 to allow for their to change the size of the array
Console.WriteLine($"Last score: {scores[scores.Length - 1]}");

List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry" };
// Remove a fruit in the list. Not pineapple because it is not in the list
fruits.Remove("Apple");

// Put in an actuall fruit
fruits.Add("Date");

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit.ToUpper()); // Check this line
}

Console.Write("Pick a number between 1 and 3: ");
// Added a null coalescing operator to prevent a null input
int choice;
do
{
    choice = int.TryParse(Console.ReadLine() ?? "0", out choice) ? choice : 0;
    // adding an if statement to check for valid input
    if (choice < 1 || choice > 3)
    {
        Console.WriteLine("Invalid choice. Please pick a number between 1 and 3.");
    }
} while (choice < 1 || choice > 3);
    // Change choice to choice
switch (choice)
{
    case 1:
        Console.WriteLine("You picked one!");
        // Add break
        break;
    case 2:
        Console.WriteLine("You picked two!");
        // Add break
        break;
    case 3:
        Console.WriteLine("You picked three!");
        // Add break
        break;
    default:
        Console.WriteLine("That’s not between 1 and 3!");
        // Add break
        break;
}
//Rewriten with a formate string for readablility
Console.WriteLine($"Thanks for debugging, {name} !");
Console.WriteLine("Press Enter to exit.");
Console.ReadLine();
