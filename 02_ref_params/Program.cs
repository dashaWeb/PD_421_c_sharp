internal class Program
{
    static void BadSwap(int x, int y) // параметри передаються за значенням (приходить копії значень)
    {
        var tmp = x;
        x = y; 
        y = tmp;
    }
    // ref, out - передача за посиланням
    // ref = переданий фактичний параметр ПОВИНЕН БУТИ ПРОІНІЦІАЛІЗОВАНИЙ
    // out - переданий фактичний параметр може бути НЕ  ПРОІНІЦІАЛІЗОВАНИЙ, тобто параметр для збережнггя результату
    static void Swap(ref int x, ref int y)
    {
        var tmp = x;
        x = y;
        y = tmp;
    }
    static void Inc(ref int value)
    {
        value++;
    }
    static void SumTwo(int a, int b, out int res)
    {
        res = a + b;
    }
    private static void Main(string[] args)
    {
        // value types (struct, enum, int, double .... ) Stack - копіювання значень
        // reference types  (class, string, StringBuilder, interface, delegate, array) Heap

        int a = 5, b = 10;
        Console.WriteLine($"a = {a,-10} b = {b}");
        //BadSwap(a, b);
        Swap(ref a, ref b);
        Console.WriteLine($"a = {a,-10} b = {b}");

        int value = 1;
        Inc(ref value);
        Console.WriteLine(value);

        int res;
        SumTwo(a, b, out res);
        Console.WriteLine($"Result :: {res}");
    }
}