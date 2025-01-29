using System.Linq;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        // result = from item_name,item_name2 in source
        //          select result_value
        //SELECT
        int[] arrayInt = { 5, 34, 67, -12, 94, -42 };
        Print(arrayInt);
        IEnumerable<int> query = from i in arrayInt
                                 select i * -1;

        Print(query);
        query = arrayInt.Select(ConverData);
        Print(query);
        query = arrayInt.Select(delegate (int item) { return item / 2; });
        Print(query);
        query = arrayInt.Select(item => item + 2);
        Print(query);

        // Where
        query = from i in arrayInt
                where i % 2 == 0
                select i;
        Print(query, "\nTest Where even");
        query = arrayInt.Where(item => item % 2 != 0).Select(i => i * -1);
        Print(query, "\nTest Where odd");

        string[] colors = { "red", "blue", "green", "purple", "brown", "black", "pink", "orange", "yellow", "lime", "gold" };

        var result = from color in colors
                     where color.Length == 4
                     select color;
        Print(result, "\nTest where string");

        result = colors.Where(color => color.Length == 4);
        Print(result, "\nTest where string");
        WriteLine($"Max length :: {colors.Max(color => color.Length)}");

        // OrderBy
        query = from i in arrayInt
                where i % 2 == 0
                orderby i
                select i;
        Print(query, "\nTest orderby");
        query = arrayInt.Where(item => item % 2 == 0).OrderByDescending(i => Math.Abs(i));
        Print(query, "\nTest orderby");
    }
    static int ConverData(int item)
    {
        return item * 2;
    }
    static void Print<T>(IEnumerable<T> source, string prompt = "")
    {
        WriteLine(prompt);
        foreach (var item in source)
        {
            Write(item + "\t");
        }
        WriteLine();
    }
}