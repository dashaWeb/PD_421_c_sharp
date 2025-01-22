internal class Program
{
    private static void Main(string[] args)
    {
        string fname = "../../../info.txt";
        /*using (StreamWriter sw = new StreamWriter(fname)) {
            string line = "Hello from C# Streams";
            int value = 123456;
            DateTime today = DateTime.Now;
            int[] arr = { 10, 20, 30, 40, 50 };

            sw.WriteLine(line);
            sw.WriteLine($"value :: {value}");
            sw.WriteLine(today);
            sw.WriteLine(arr.Length);
            foreach (var item in arr)
            {
                sw.WriteLine(item);
            }
        }*/

        // 1 way
        Console.WriteLine($"Content ReadAllLines");
        string[] lines = File.ReadAllLines( fname );
        foreach (var item in lines)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(new string('*',50));

        // 2 way 
        Console.WriteLine($"Content ReadAllText \n {File.ReadAllText(fname)}");

        //3 way
        Console.WriteLine(new string('*',50));

        using(StreamReader sr = new StreamReader(fname))
        {
            Console.WriteLine($"Content ReadToEnd -- {sr.ReadToEnd()}");
        }

        //4 way
        Console.WriteLine(new string('*', 50));

        using (StreamReader sr = new StreamReader(fname))
        {
            Console.WriteLine($"Content (line by line )");
            string line;
            //sr.EndOfStream()
            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        //5 way
        Console.WriteLine(new string('*', 50));

        using (StreamReader sr = new StreamReader(fname))
        {
            Console.WriteLine($"Content (char by char )");
            int symbol;
            //sr.EndOfStream()
            while ((symbol = sr.Read()) != -1)
            {
                Console.WriteLine((char)symbol);
            }
        }
    }
}