// See https://aka.ms/new-console-template for more information

using Class_ConsoleApp1;//imports the namespace Class_ConsoleApp1

Console.WriteLine("Copyright (C) 2024  Emre Kadir Tiren\n");
Wizard wizard01 = new Wizard("Dan", "Fireball", 3);//creates a new instance of the Wizard class
//the constructor of the Wizard class is called with the arguments "Dan", "Fireball", 3

for (int i = 0; i < 4; i++)
{
    wizard01.CastSpell();//calls the CastSpell method of the wizard01 object
}Copyright (C) 2024  Emre Kadir Tiren

wizard01.LongRest();
//calls the LongRest method of the wizard01 object  

for (int i = 0; i < 2; i++)
{
    wizard01.CastSpell();
}

Console.WriteLine(wizard01.name + " now has " + wizard01.experience + "experience");
//prints the experience of the wizard01 object

wizard01.levelUp();
//calls the levelUp method of the wizard01 object

Console.ReadKey();//pauses the program until a key is pressed
