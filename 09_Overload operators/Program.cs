using _09_Overload_operators;

internal class Program
{
    private static void Main(string[] args)
    {
      Fraction one  =new Fraction(1,2);
      Fraction two  =new Fraction(0,3);
        Console.WriteLine($"{one} + {two} = {one+two}");
        Console.WriteLine($"{one} = {++one}");
        Console.WriteLine($"{one} == {two} = {one==two}");
        Console.WriteLine($"{one} != {two} = {one!=two}");
        Console.WriteLine($"{one[0]} {one[1]}");
        Console.WriteLine(two?"True":"False");
        if(one)
        { Console.WriteLine("True"); }
        else { Console.WriteLine("False"); }
        Console.WriteLine($"{one} --> {(int)one}"); // явне перетворення типів
        double dd = one; //// неявне перетворення типів
        Console.WriteLine($"{one} --> {dd}");
    }
}