

internal class Program
{
    private static void Main(string[] args)
    {
        Action act = () => { Console.WriteLine("Hello from std delegate"); };
        act();
        act += Hello;
        Console.WriteLine();
        act();
        act += () => Console.WriteLine("Studing delegate");
        Console.WriteLine();
        act();

        Action<string,int> act2 = (str,number)=> Console.WriteLine($"#{number} :: {str}");
        act2("Test", 10);

        Func<int, int, double> funcAvg = (one,two) => (one+ two) /2.0;
        Console.WriteLine($"Func avg(10,11) = {funcAvg(10,11)}");

        Predicate<string> pred = s => char.IsUpper(s[0]);
       
        Console.WriteLine($"Has first upper letter :: {pred("Good")}"); // true
        Console.WriteLine($"Has first upper letter :: {pred("error")}"); // false

        Comparison<string> cmp = (s1,s2) => s1.Length.CompareTo(s2.Length);
        string wordA = "Program";
        string wordB = "Python";
        Console.WriteLine($"Test Comparison by length :: {cmp(wordA,wordB)}"); // 1
        Console.WriteLine($"Test Comparison by length :: {cmp(wordB,wordA)}"); // -1
    }

    static void Hello()
    {
        Console.WriteLine("Hello from std delegate");
    }
}