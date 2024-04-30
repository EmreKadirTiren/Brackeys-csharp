// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Meetalien();//runs the Meetalien function
Meetalien();
Meetalien();


static void Meetalien()//function that returns nothing
{
    Random numberGen = new Random();

    string name = "X-" + numberGen.Next(0, 1000);//generates a random number between 0 and 1000
    int age = numberGen.Next(18, 1000);//generates random num between 18 and 1000
    Console.WriteLine("Hi I am" + name + "nice to meet you\ni am" + age + "yearls old");//says something
    Console.WriteLine("Oh and I am an alien");//says something more
}