internal class Program
{
    static void InputSymbol()
    {
        Console.WriteLine("Enter one symbol : ");
        char symbol = (char)Console.Read();
        Console.WriteLine("Symbol   :: " + symbol);
        Console.WriteLine("Letter   :: " + char.IsLetter(symbol));
        Console.WriteLine("Is Upper :: " + char.IsUpper(symbol));
        Console.WriteLine("Digit    :: " + char.IsDigit(symbol));
    }
    private static void Main(string[] args)
    {
        /*InputSymbol();*/
        //Task();

        /*Console.Write("Enter number :: ");
        string text = Console.ReadLine();*/
        // way 1
        /*double res = Convert.ToDouble(text);
        res = res + 10;
        Console.WriteLine($"Result :: {res}");*/
        // way 2
        /*text = Console.ReadLine();
        var res = int.Parse(text);
        res = res + 10;
        Console.WriteLine($"Result :: {res}");*/

        /*text = Console.ReadLine();
        int res;
        if (int.TryParse(text, out res))
        {
            res = res + 10;
            Console.WriteLine($"Result :: {res}");
        }*/

        /*Console.Write("Enter number of day :: ");
        int day = Convert.ToInt32(Console.ReadLine());*/
        // ==, !=, >, <, >=, <=
        // && - and; || - or
        /*if(day == 1)
        {
            Console.WriteLine("Monday");
        }
        else if(day == 2)
        {
            Console.WriteLine("Tuesday");
        }
        else if(day == 3)
        {
            Console.WriteLine("Wednesday");
        }
        else
        {
            Console.WriteLine("Error");
        }*/
        /*switch (day)
        {
            case 1:
            case 3:
                Console.WriteLine("Monday");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }*/
        /*int i = 0;
        for (; ;)
        {
            i++;
            Console.WriteLine(i + " Hello");
            if (i >= 5)
                break;
        }
        Console.WriteLine(i);*/
        /*ConsoleKey key;
        while ((key = Console.ReadKey().Key) != ConsoleKey.Escape)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("UpArrow");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("LeftArrow");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("DownArrow");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("RightArrow");
                    break;
                default:
                    break;
            }
        }*/
        /*int res;
        do
        {
            Console.Write("2 + 2 = ");
            res  = Convert.ToInt32(Console.ReadLine());

        } while (res != 4);*/
        // +,-,*,/, %
        // res+= 2;
        //Math.Pow();
        /*int number = 22;
        Console.WriteLine(@$"
            Test
                    Test
                      {number}      \n
            
            \t tttttt
        ");*/
        /*int test = 4;
        while ((bool)test) // Error
        {
            Console.WriteLine("---------");
        }*/

    }

    static void Task()
    {
        Console.ResetColor();
        /* Console.BackgroundColor = ConsoleColor.DarkGray;
         Console.ForegroundColor= ConsoleColor.Green;
         Console.CursorLeft = 40;
         Console.CursorTop = 12;*/
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        string line = "C# language - популярна мова під .NET";
        Console.WriteLine(line);

        System.String str = "Hello !!!";
        double d = 23.456789;
        decimal money = 123_456.890_123m;
        float f = 189.55f;
        var v = 777.8888;

        // 1) write 
        Console.WriteLine("Money = " + money);

        //2) format line
        Console.WriteLine("Float {0} value {0} f = {0} \t SQRT = {1}", f, Math.Sqrt(f));

        // 3) interpolation line 
        Console.WriteLine($"Message :: {str}");
        Console.WriteLine($"Value v * 2 =  {v * 2,-20} ++f = {++f}");

        // 4 
        Console.WriteLine(@"
            Test
                    Test
                            \n
            \t tttttt
        ");
    }
}