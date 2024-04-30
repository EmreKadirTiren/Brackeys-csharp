// See https://aka.ms/new-console-template for more information

Console.WriteLine("Copyright (C) 2024  Emre Kadir Tiren");

int i; //declares variable i of type int
for (i = 0; i < 10; i++) //initializes i to 0, checks if i is less than 10,runs the program and then increments i by 1
{
    Console.WriteLine(i); //prints i
}

while (i<=15) //this is a while loop that runs as long as i is less than or equal to 15
{
    Console.WriteLine(i); //prints i
    i++; //increments i by 1
}

//Normally when u want a loop to run a certain number of times, you use a for loop
//When you want a loop to run until a certain condition is met, you use a while loop 

Console.ReadKey();//this is used to keep the console window open until a key is pressed