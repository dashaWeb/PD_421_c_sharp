internal class Program
{
    delegate bool Condition<T>(T a);
    /*static int CountInArray(int[] arr, Condition func) // func - перевірка умови
    {
        int counter = 0;
        foreach (int i in arr)
        {
            if (func(i))
            {
                counter++;
            }
        }
        return counter;
    }*/
    static int CountInArray<T>(T[] arr, Condition<T> func) // func - перевірка умови
    {
        int counter = 0;
        foreach (T i in arr)
        {
            if (func(i))
            {
                counter++;
            }
        }
        return counter;
    }
    private static void Main(string[] args)
    {
        int[] arr = { 5, 7, 8, -5, -8, 11, -6, 0, 1, 2, -4 };
        Console.WriteLine($"Number of positive elements :: {CountInArray(arr, e=> e>0)}");
        Console.WriteLine($"Number of negative elements :: {CountInArray(arr, e => e <= 0)}");
        Console.WriteLine($"Number of odd elements :: {CountInArray(arr, e => e % 2 != 0)}");
        Console.WriteLine($"Number of even elements :: {CountInArray(arr, e => e % 2 == 0)}");
        double[] arr2 = { 2.5, -5.3, -4.3, 2.3, 2.1, 6.2 };
        Console.WriteLine($"Number of positive elements :: {CountInArray(arr2, e=> e>0)}");
        string[] arr3 = { "red", "yellow", "blue", "orange" };
        Console.WriteLine($"Number of positive elements :: {CountInArray(arr3, e => e.Length >= 5)}");

    }

}