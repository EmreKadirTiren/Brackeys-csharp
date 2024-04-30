// See https://aka.ms/new-console-template for more information
Console.WriteLine("Copyright (C) 2024  Emre Kadir Tiren\n");

Console.WriteLine("Type 1 or 2");

double num = Convert.ToDouble(Console.ReadLine());
//converts string from readline to double

switch (num) //checks if num is equel to any of the cases if not default wil run
{
    case 1:
        Console.WriteLine("one");
        break;//means exit the switch and continu
    
    default:
        Console.WriteLine("default");
        break;
}// will continiu here when break; is called
    
    Console.ReadKey();
    // waits for key input before closing