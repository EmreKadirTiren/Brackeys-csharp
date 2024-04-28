// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//Now lets create a program that will spit out a top 5 movie list
    string[] topMovies = { "The Godfather", "The Shawshank Redemption", "Schindler's List", "Raging Bull", "Casablanca" };
    Console.WriteLine("Top 5 Movies of All Time");
    for (int i = 0; i < topMovies.Length; i++)
    {
        int rank= i + 1;
        Console.WriteLine(rank+". "+topMovies[i]);
    }
//this will print out the top 5 movies of all time
