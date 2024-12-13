using System.Data;
using System.Text;

internal class Program
{
    /*static int SUMINT(int a, int b)
    {
        return a + b;
    }
    static int SUMINT(int a, int b, int c)
    {
        return a + b + c;
    }*/

    static int sum(string text, params int[] numb)
    {
        return numb.Sum();
    }
    private static void Main(string[] args)
    {
        string text = "lorem ipsum dolor C#";
        Console.WriteLine(text);
        //text[0] = Char.ToLower(text[0]); // compile error, string - immutable
        char[] chars = text.ToCharArray();
        chars[0] = Char.ToUpper(chars[0]);
        text = new string(chars);

        Console.WriteLine(text);
        string word = "C#";
        Console.WriteLine($"\n Contains '{word}' :: {text.Contains(word)}");
        Console.WriteLine($"\n IndexOf '{word}' :: {text.IndexOf(word)}"); // -1 not found

        Console.WriteLine($"\n StartsWith '{word}' :: {text.StartsWith(word)}"); // -1 not found
        Console.WriteLine($"\n StartsWith '{word}' :: {text.EndsWith(word)}"); // -1 not found

        string letter = "ips";
        int index = text.IndexOfAny(letter.ToCharArray());
        if(index != -1) // ok found
        {
            Console.WriteLine($" \n Index of first from '{letter} :: {index}. Letter :: {text[index]}'");
        }


        string one = "Apple", two = "Apricot"; // one < two
        Console.WriteLine($"{one} == {two} --> {one == two}");
        Console.WriteLine($"{one}.CompareTo {two} --> {one.CompareTo(two)}");
        two = "apple";
        Console.WriteLine($"{one}.CompareTo {two} --> {one.CompareTo(two)}");
        Console.WriteLine(String.CompareOrdinal(one, two)); // A = 65, a = 97
        Console.WriteLine(String.Compare(one, two,true)); // A = 65, a = 97
        Console.WriteLine($"Origin Text :: {text}");
        Console.WriteLine($"text.Remove --> {text.Remove(5, 10)}");
        Console.WriteLine($"text.Remove --> {text.Replace("C#","JavaScript")}");
        Console.WriteLine($"text.Remove --> {text.Insert(0, "Next Text")}");
        Console.WriteLine($"text.Remove --> {text.Substring(0,10)}");

        string number = "1,2,3,4,5,6,7,8,9,7";
        string[] numbers = number.Split(',', StringSplitOptions.RemoveEmptyEntries);
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
        string[] color = { "red", "green", "blue" };
        Console.WriteLine(String.Join(" --- ",color));

        Console.WriteLine(sum("text",1,2,3,4,5,6,7,8,9,5,4,7,5));


        /*StringBuilder stringBuilder= new StringBuilder(text);
        stringBuilder[0] = Char.ToLower(stringBuilder[0]);
        Console.WriteLine(stringBuilder.Capacity);
        stringBuilder.Append("test test test test");
        Console.WriteLine(stringBuilder);
        stringBuilder.Insert(0, "test");
        Console.WriteLine(stringBuilder);
        stringBuilder.Remove(5, 5);
        Console.WriteLine(stringBuilder);
        stringBuilder.Replace("test", " C# ");
        Console.WriteLine(stringBuilder);
    */
    }
}