// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Meetalien();
Meetalien();
Meetalien();


static void Meetalien()
{
    Random numberGen = new Random();

    string name = "X-" + numberGen.Next(0, 1000);
    int age = numberGen.Next(18, 1000);
    Console.WriteLine("Hi I am" + name + "nice to meet you\ni am" + age + "yearls old");
    Console.WriteLine("Oh and I am an alien");
}