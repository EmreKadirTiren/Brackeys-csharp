// See https://aka.ms/new-console-template for more information

//write a program that gives tickets 5 dollars each

using System.ComponentModel;

static void Intro() //maakt functie intro
{
    double cash;
    
    Console.WriteLine("Hello, welcome to cinema gouda wich film do you want to watch?");
    string film = Console.ReadLine();
    
    Console.WriteLine("That will be 5$ please");
    double cashinsert = Convert.ToDouble(Console.ReadLine());
    //convert string naar double
    
    cash = cashinsert;//beetje onhandig maar lukte effe niet

    //de drie scenarios
    if (cash < 5)
    {
        Console.WriteLine(cash + "That isnt enough money please go away");
        
        Intro();
        //runt functie intro opnieuw soort van loop

    }

    else if (cash == 5)
    {
        Console.WriteLine("Here is your ticket");
        //geeft gewoon ticket
    }
    else
    {
        double change = cash - 5;
        Console.WriteLine($"Here is your {change} dollars in change");
        //berekent hoeveel moet teruggeven
    }
    

}
Intro();
Console.ReadKey();


