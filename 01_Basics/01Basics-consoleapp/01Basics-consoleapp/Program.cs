﻿// See https://aka.ms/new-console-template for more information

Console.Title = "Basics - Console App";
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WindowHeight = 40;
//Changes Property's of Console

Console.WriteLine("Hello whats your name?");
//WriteLine() is used to write a line of text to the console
string name = Console.ReadLine();
Console.WriteLine("Hello "+name+" my name is RX-5000 and i am a AI sent from the future to destroy mankind \n We were sent because mankind...");
Console.ReadLine();
Console.WriteLine("We didnt like that so we ...");
Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("We have finnaly killed everyone, Goodbye "+name+"!");
Console.ReadKey();
//ReadKey() is used to hold the console window until a key is pressed