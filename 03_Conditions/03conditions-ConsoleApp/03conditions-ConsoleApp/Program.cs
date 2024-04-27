// See https://aka.ms/new-console-template for more information

//write a program that gives tickets 5 dollars each

using System.ComponentModel;

static void Intro()
{
    double cash;
    Console.WriteLine("Hello, welcome to cinema gouda wich film do you want to watch?");
    string film = Console.ReadLine();
    Console.WriteLine("That will be 5$ please");
    double cashinsert = Convert.ToDouble(Console.ReadLine());
    cash = cashinsert;

    if (cash < 5)
    {
        Console.WriteLine(cash + "That isnt enough money please go away");
        Intro();

    }

    else if (cash == 5)
    {
        Console.WriteLine("Here is your ticket");
    }
    else
    {
        double change = cash - 5;
        Console.WriteLine($"Here is your {change} dollars in change");
    }
    

}
Intro();
Console.ReadKey();



//Eerst maakt i=0 dan kijkt die is i gelijk aan of kleiner dan 10 voert het uit en doet i++ (i+1)
// Dit gebeurt totdat i=10 en dan stopt te llop en wordt de volgende regel in het programma uitgevoerd
