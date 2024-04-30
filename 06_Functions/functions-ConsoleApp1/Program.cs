// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, put in a number");
int num1 = Convert.ToInt32(Console.ReadLine()); //collects num1
Console.WriteLine("Put in a second number");
int num2 = Convert.ToInt32(Console.ReadLine());//collects num2

int result = Multiply(num1, num2);//uses multiply function
Console.WriteLine($"If you multiply both numbers you get {result}");

if (result % 2 == 0)//if statement to check if even
{
    Console.WriteLine("Which is a even number");
}
else
{
    Console.WriteLine("That is a uneven number");
}




Console.ReadKey();//waits for key input before closing

static int Multiply(int num1, int num2)
    //(int num) means it takes what was put in brackets it runs the function and gives back
    //int not void (wich means nothing) means that it returns a int
{
    int result = num1 * num2;//multiplys num1 and 2
    return result;//returns the result
}