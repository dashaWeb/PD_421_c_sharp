internal class Program
{
    static void Print<T>(T[] arr, string prompt = "")
    {
        Console.Write(prompt + " :: ");
        /*for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }*/
        foreach (var item in arr)
        {
            Console.Write(item + "\t");
        }
        Console.WriteLine();
    }
    static void Fill(int[] arr, int min = 0, int max = 100) // масив приходить по посилання, мвсив - ref типу
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max);
        }
    }
    static void PushBack(ref int[] arr, int value)
    {
        //int[] tmp = new int[arr.Length + 1];
        /*for (int i = 0; i < arr.Length; i++)
        {
            tmp[i] = arr[i];
        }*/
        /*arr.CopyTo(tmp, 0);
        tmp[tmp.Length - 1] = value;
        arr = tmp;*/

        Array.Resize(ref arr, arr.Length + 1);
        arr[arr.Length - 1] = value;
    }
    private static void Main(string[] args)
    {
        // class Array - абстрактний клас, від якого упадковуються масиви
        // бібліотека Linq - методи розширення роботи з масивом

        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        Print(arr, "Print Array");
        int[] arr2 = { 10, 20, 30, 40 };
        Print(arr2, "Print Array2 ");

        /*Console.WriteLine("Enter size of array");
        int size = int.Parse(Console.ReadLine());*/
        int size = 10;
        int[] arr3 = new int[size];
        Fill(arr3, -10, 10);
        Print(arr3, "Print rand array           ");
        PushBack(ref arr3, 333);
        Print(arr3, "Print array after pushback ");

        Console.WriteLine("Input value for seach ");
        int value = 10;//int.Parse(Console.ReadLine());

        int index = Array.IndexOf(arr3, value);
        if (index != -1)
        {
            Console.WriteLine($"Value {value} was found in index {index}");
            int lastIndex = Array.IndexOf(arr3, value);
            Console.WriteLine($"Value {value} (last occur) was found in index {lastIndex}");
        }
        else
        {
            Console.WriteLine($"Value {value} not found");
        }

        // Linq
        value = 3;
        if (arr.Contains(value))
        {
            Console.WriteLine($"Value {value} was found");
        }
        else
        { Console.WriteLine($"Value {value} not found"); }

        Console.WriteLine();
        int indFirstPositive = Array.FindIndex(arr3, IsPositive);
        if (indFirstPositive != -1)
        {
            Console.WriteLine($"Found positive {arr[indFirstPositive]}");
        }
        else
        {
            Console.WriteLine("Not found any positive in array");
        }

        // Linq Count(....)
        Console.WriteLine($"\n Number of positive elements :: {arr3.Count(IsPositive)}");
        int[] positives = Array.FindAll(arr3, IsPositive);
        Print(positives, "Print all positive elements");

        // лямбда (format param-list) => {.. return ;};
        //int[] events = Array.FindAll(arr3, (int e) => { return e % 2 == 0; });
        int[] events = Array.FindAll(arr3, e => e % 2 == 0);
        Print(events, "Print all events elements");

        Console.WriteLine(Array.TrueForAll(arr3, IsPositive));
        int div = 3;
        Console.WriteLine(Array.Exists(arr3, e => e % div == 0));

        Console.WriteLine();
        Console.WriteLine();
        Array.Sort(arr3);
        Print(arr3, "Print rand array");
        Array.Reverse(arr3);
        Print(arr3, "Print rand array");

        string[] color = { "red", "green", "Yellow", "gold", "Pink", "aqua" };
        Array.Sort(color);
        Print(color);
        Array.Sort(color, (s1,s2) => s1.Length.CompareTo(s2.Length));
        Print(color);
    }
    static bool IsPositive(int a) // предикат, логічна функція
    {
        return a > 0;
    }
}