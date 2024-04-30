// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Copyright (C) 2024  Emre Kadir Tiren\n")
static void Intro()
{
    string text = "Hello, World! What a wonderful day! :) \nWhat is your name?";
    Console.WriteLine(text);
    string userName = Console.ReadLine();
    Console.WriteLine($"Hello, {userName}! How are you today?");
    
}

int num1;
int num2;
int result;

Intro();
Console.WriteLine("Input a number:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input another number:");
num2 = Convert.ToInt32(Console.ReadLine());
result = num1 + num2;
Console.WriteLine($"The sum of {num1} and {num2} is {result}.");
Console.ReadKey();