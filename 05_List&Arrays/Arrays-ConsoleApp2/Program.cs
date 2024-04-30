// See https://aka.ms/new-console-template for more information

Console.WriteLine("Copyright (C) 2024  Emre Kadir Tiren\n");

//Now lets create a program that will spit out a top 5 movie list
    string[] topMovies = { "The Godfather", "The Shawshank Redemption", "Schindler's List", "Raging Bull", "Casablanca" };
//Stores 5 movies
    Console.WriteLine("Top 5 Movies of All Time");
    for (int i = 0; i < topMovies.Length; i++)
    {
        int rank= i + 1;
        Console.WriteLine(rank+". "+topMovies[i]);
    }
//loop that will print out the top 5 movies of all time

Console.ReadKey();//Waits for key input before closing