

internal class Program
{
    private static void Main(string[] args)
    {
        // Enumerable -  те що перелічується, по ньому можна переміщатися
        // Enumerator - той, хто переміщується

        // низькорівневий обхід масиву
        int[] arr = { 1, 2, 3, 44, -100 };
        var enArr = arr.GetEnumerator();
        while (enArr.MoveNext())
        {
            Console.Write($"{enArr.Current,7}");
        }
        Console.WriteLine();

        string str = "Lorem ipsum";
        var enStr = str.GetEnumerator();

        while (enStr.MoveNext())
        {
            Console.Write($"{enStr.Current,7}");
        }
        Console.WriteLine();
    }
}