namespace Class_ConsoleApp1;

public class Wizard
{
    public string name;
    public string favoriteSpell;
    public int originalSpellSlot;
    public int spellSlot;
    public float experience;
    

    public Wizard(string _name, string _favoriteSpell, int _spellSlot)
    {
        name = _name;
        favoriteSpell = _favoriteSpell;
        spellSlot = _spellSlot;
        originalSpellSlot = _spellSlot;
        experience = 0f;
    }
    
public void CastSpell()
    {
        if (spellSlot > 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(name+" casts "+favoriteSpell);
            spellSlot--;
            experience += 0.3f;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{name} is out of spell slots, he must take a long rest");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        
    }
public void LongRest()
    {
        spellSlot = originalSpellSlot;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(name + " has taken a long rest and has regained all "+spellSlot+" of his spell slots");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
public void levelUp()
    {
        experience = 0f;
        originalSpellSlot++;
        spellSlot = originalSpellSlot;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(name + " has leveled up and now has "+spellSlot+" spell slots");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

}