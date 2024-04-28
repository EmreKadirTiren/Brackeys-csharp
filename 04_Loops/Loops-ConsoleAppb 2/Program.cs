// See https://aka.ms/new-console-template for more information
//Task: Make a cool number generator that generates the power of a number that
//the user can choose and how many times it must power it
//Use the line:

double num;
double times;

Console.WriteLine("Choose a nummer");
num = Convert.ToInt32(Console.ReadLine());//This will ask the user for the number that must be powered
Console.WriteLine("How many cool numbers do you want?");
times = Convert.ToInt32(Console.Read());//This will ask the user for the number and how many times it must be powered

for (int i = 0; i <= times; i++)//This is the loop that will generate the cool numbers
{
    double answer = Math.Pow(num, i);//This is the math function that will generate the cool numbers
    Console.WriteLine(answer);//This will print the cool numbers
}
Console.ReadKey();//This will keep the console open
