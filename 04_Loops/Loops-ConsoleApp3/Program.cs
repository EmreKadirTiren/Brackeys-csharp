// See https://aka.ms/new-console-template for more information
//Make a simple program that lets you roll until you roll a six
//Use the line numberGen.Next(1, 7); to generate a random number between 1 and 6
//Give the user how many attempts it took to roll a six

using System.Security.Cryptography;

Random numberGen = new Random();
int roll=0;
int attempts = 0;

Console.WriteLine("Hello, how many rolls will it take to roll a six?\n Press any key to roll");

while (roll != 6)
{
    Console.ReadKey();
    roll=numberGen.Next(1,7);
    attempts++;
    Console.WriteLine($"You rolled a {roll}");
}
Console.WriteLine($"Good job! It took you {attempts} attempts to roll a six");
Console.ReadKey();