﻿// Declare variables
using System.Xml.Linq;

string firstName;
string lastName;
int age;
int retirementAge = 65;

// Prompt the user for input
Console.WriteLine("Please enter your first name:");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name:");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
