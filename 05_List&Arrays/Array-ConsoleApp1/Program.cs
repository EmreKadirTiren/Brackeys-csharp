// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static void names()
{
    string[] names = { "Adam", "Barry", "Charlie" };//a variable but it can store more than one value
//string[] names = new string[3]; //another way to declare an array you must specify the size of the array
//to acces an element in the array you use the index of the element
//that means 0 for adam, 1 for barry and 2 for charlie ect.
    Console.WriteLine(names[0]);
//it now prints adam
//you can also change the value of an element in the array
    names[0] = "Edward";
    Console.WriteLine(names[0]);
//it now prints edward
}


//Now lets create a program that will spit out a top 5 movie list
string[] topMovies = { "The Godfather", "The Shawshank Redemption", "Schindler's List", "Raging Bull", "Casablanca" };
Console.WriteLine("Top 5 Movies of All Time");
for (int i = 0; i < topMovies.Length; i++)
{
    int rank= i + 1;
    Console.WriteLine(rank+". "+topMovies[i]);
}
//this will print out the top 5 movies of all time


Console.ReadKey();
