using _19_Structure_Demo;

internal class Program
{
    private static void Main(string[] args)
    {
        City city = new City();
        Console.WriteLine(city);

        City rivne = new City("Rivne",240_451);
        Console.WriteLine(rivne);

        City clone = rivne; // поверхневе копіювання
        Console.WriteLine(clone);

        Console.WriteLine("------------------------");
        clone.Name = "Rivne - 2";
        clone.Population++;
        Console.WriteLine("Origin --> " + rivne);
        Console.WriteLine("Clone  --> " + clone);


        int val1 = 22;
        int val2 = 123;

        // 22 < 123 ==> -1
        Console.WriteLine(val1.CompareTo(val2)); // -1
        Console.WriteLine(val2.CompareTo(val1)); // 1
        int val = 123;
        Console.WriteLine(val2.CompareTo(val)); // 0
        int[] arr = { 10, 23, -4, 2, -45, 3, 2 };
        Console.WriteLine(String.Join<int>(", ", arr));
        Array.Sort(arr);
        Console.WriteLine(String.Join<int>(", ", arr));

        City lviv = new City("Lviv",710_606);
        Console.WriteLine(lviv.Population.CompareTo(rivne.Population));

        City[] cities =
            {
            new City("Kyiv",2_952_000),
            new City("Poltava",272_572),
            rivne,
            lviv
        };
        foreach (var city_ in cities)
        {
            Console.WriteLine(city_);
        }
        Console.WriteLine();
        //Array.Sort(cities, (a, b) => -a.Population.CompareTo(b.Population));
        Array.Sort(cities);
        foreach (var city_ in cities)
        {
            Console.WriteLine(city_);
        }

        Console.WriteLine();

        var cmpName = new ComparerByName();
        Array.Sort(cities,cmpName);
        foreach (var city_ in cities)
        {
            Console.WriteLine(city_);
        }

        Console.WriteLine();

        Array.Sort(cities, new CompareByNameDesc());
        foreach (var city_ in cities)
        {
            Console.WriteLine(city_);
        }

        Console.WriteLine();

     
    }
}