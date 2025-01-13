

delegate double CalcDelegate(double one, double two);
class Calculate
{
    public static double Add(double a, double b) => a + b;
    public static double Sub(double a, double b) => a - b;
    // non - static
    public  double Mult(double a, double b) => lastResult = a * b;
    private double lastResult = 1;
    public override string ToString()
    {
        return $"Last multiplication result = {lastResult}";
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        CalcDelegate del = Calculate.Add;
        Console.WriteLine($"Method :: {del.Method}");
        Console.WriteLine($"Result :: {del(2,3)}");

        del += Calculate.Sub;
        Console.WriteLine($"Method :: {del.Method}");
        Console.WriteLine($"Result :: {del(2, 3)}");

        Console.WriteLine("\n ---- Get Results from Invocation List -----");
        foreach (var item in del.GetInvocationList())
        {
            Console.WriteLine($"operation {item.Method} ::: {item.DynamicInvoke(10,15)}");
        }

        Calculate calc = new Calculate();
        del = calc.Mult; // Target calc
        del(4, 10);
        Console.WriteLine($"Method :: {del.Method}");
        Console.WriteLine($"Target :: {del.Target}");
        Console.WriteLine(calc);
    }
}