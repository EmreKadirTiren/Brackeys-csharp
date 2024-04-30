// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//create a method that coutns words in a sentece and return a number
//Use the next code:
//string input = "I love programing";
//int inputlength=input.Split(' ').Length;//splits words that means var turns into array and than gives length

Console.WriteLine("Hello im a wordcounter please write something");
string inputText = Console.ReadLine();//reads input
int inputLength = wordcounter(inputText);//calls method and gives input
Console.WriteLine($"Your text is {inputLength} words long.");//prints out the result
Console.ReadKey();//keeps console open


static int wordcounter(string input)//method that counts words
{
    int inputlength = input.Split(' ').Length;//splits words that means var turns into array and gives length
    return inputlength;//returns the length
}
