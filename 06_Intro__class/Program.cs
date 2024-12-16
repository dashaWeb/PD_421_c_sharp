using _06_Intro__class;

internal class Program
{
    private static void Main(string[] args)
    {
       Character character = new Character("Elf",100,5);
        character.Print();
        Console.WriteLine(character);

        character.Name = "   ";
        character.Name = "Kind Elf";
        Console.WriteLine(character);
        //character.KPD= 245; //error немає set
        Console.WriteLine(character.KPD);
        Character character2 = new Character(hp:150, damage:2, newName:"Mage"); // виклик конструктора (можна так для методів) з ІМЕНОВАНИМИ параметрами
        Console.WriteLine(character2);
        // через конструктор за замовчуванням та список ініціалізації (через відкриті поля та властивості)
        Character character3 = new Character { Name = "Warrior", Damage = 10 };
        Console.WriteLine(character3);
    }
}

