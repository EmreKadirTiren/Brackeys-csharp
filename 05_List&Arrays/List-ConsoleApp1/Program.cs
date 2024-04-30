// See https://aka.ms/new-console-template for more information

Console.WriteLine("Copyright (C) 2024  Emre Kadir Tiren\n");
Console.WriteLine("Welcome to your shoppinglist please enter your 11 groceries");
List<string> shoppinglist = new List<string>();//creates a list
for (int i = 0; i < 11; i++)//for loop to insert groceries
{
    shoppinglist.Add(Console.ReadLine());//adds item to shoppinglist
}

for (int i = 0; i < 11; i++)//for loop to write groceries
{
    Console.WriteLine(shoppinglist[i]);
}
Console.ReadKey();//waits for input before closing