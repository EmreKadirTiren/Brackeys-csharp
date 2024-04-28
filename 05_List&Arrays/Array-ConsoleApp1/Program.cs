// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

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


Console.ReadKey();//Waits for key input before closign
