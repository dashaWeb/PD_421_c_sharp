

using _11_Exception;

internal class Program
{
    static double DivisionNumber(double a, double b)
    {
        if(b == 0)
        {
            throw new DivideByZeroException("Division by zero");
        }
        return a / b;
    }
    private static void Main(string[] args)
    {
       /* double a = 2, b = 0;
        while(true)
        {
            try
            {
                Console.WriteLine("Enter two number :: ");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                double result = DivisionNumber(a, b);
                Console.WriteLine($"{a} / {b} = {result}");
                break;
            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("\t" + ex.Message);
                Console.ResetColor();
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t" + ex.Message);
                Console.ResetColor();
            }
        }*/
        
        Product product = new Product();
        try
        {
            product.Name = "black - bread";
            Console.WriteLine(product.Name);
            product.DateIn = new DateTime(2024, 12, 25, 21, 0, 0);
        }
        catch (BadProductDateException ex)
        {
            Console.WriteLine($"Message error :: {ex.Message}");
            Console.WriteLine($"Bad value date :: {ex.ErrorDate}");
            
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Message    :: {ex.Message}");
            Console.WriteLine($"Value      :: {ex.Data["Value"]}");
            Console.WriteLine($"TimeStamp  :: {ex.Data["TimeStamp"]}");
            Console.WriteLine($"TargetSite :: {ex.TargetSite}");
            foreach (var key in ex.Data.Keys)
            {
                Console.WriteLine($"{key} ------> {ex.Data[key]}");
            }
        }
        //product.InputName();
        Console.WriteLine("Test ---------");
        
    }
}