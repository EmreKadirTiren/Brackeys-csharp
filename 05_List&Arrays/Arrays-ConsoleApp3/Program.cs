// See https://aka.ms/new-console-template for more information

Console.WriteLine("Copyright (C) 2024  Emre Kadir Tiren\n");

//Now lets create a program that will spit out a top 5 movie list with the user's input

static void movieinputoutputai()//movie input output made by copilot
{
    Console.WriteLine("How many movies do you want to enter?");
    int numMovies = Convert.ToInt32(Console.ReadLine());
    string[] topMovies = new string[numMovies];
    for (int i = 0; i < numMovies; i++)
    {
        Console.WriteLine("Enter movie " + (i + 1));
        topMovies[i] = Console.ReadLine();
    }

    Console.WriteLine("Top " + numMovies + " Movies of All Time");
    for (int i = 0; i < topMovies.Length; i++)
    {
        int rank = i + 1;
        Console.WriteLine(rank + ". " + topMovies[i]);
    }
}

Console.WriteLine("How many movies do you want to enter?");//asks how many movies 
int aantalmov = Convert.ToInt32(Console.ReadLine());//converts number and stores it

string[] topmovies = new string [aantalmov];//makes aray with var aantalmov
for (int i = 0; i < aantalmov; i++)//loop that will fill in the array
{
    int rank = i + 1;
    Console.WriteLine("Enter movie " + rank);
    topmovies[i] = Console.ReadLine();
}

for (int i = 0; i < topmovies.Length; i++)//loop that wil print out the array
{
    Console.WriteLine(topmovies[i]);
}

Console.ReadKey();// Waits key to be pressed before closing