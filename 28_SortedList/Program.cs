using System.Collections;

internal class Program
{
    // колекція ооганізована як два паралельні масиви(масив ключів та масив значень)
    static void DemoSortedList()
    {
        System.Collections.SortedList list = new System.Collections.SortedList()
        {
            {10,"ten" },
            {5,"five" },
            {7,"seven" },
            {0,false },
            //{ 1.0,"one"} // exception ключі повинні бути однакового типу
        };
        PrintList(list, "Print SortedList");
        list.Add(2, "two");
        list[7] = "SEVEN";
        list[1] = "one";
        PrintList(list, "Print SortedList");

        int key = 3;
        Console.WriteLine($"Get access for key {key} :: {list[key] ?? "Null"}");
        if(!list.Contains(key))
        {
            list.Add(key, "Something");
            Console.WriteLine($"Key {key} was added!!!");
        }
        PrintList(list, "Print SortedList");

        key = 3;
        list.Remove(key);

        PrintList(list, "Print SortedList");

        int index = 0;
        if(index < list.Count)
        {
            list.RemoveAt(index);
            PrintList(list, $"After remove pair with index {index}");
        }
        Console.WriteLine($"Index {index} \t Key :: {list.GetKey(index)} \t Value :: {list.GetByIndex(index)}");
    }
    static void SortedListGen()
    {
        SortedList<int, string> list = new SortedList<int, string>()
        {
            [1000] = "Olena",
            [777] = "Ivan",
            [555] = "Pavlo"
        };
        PrintList(list, "Print Sorted List Generics");
        list.TryAdd(1000, "Test");
        list.Add(123, "Vasil");
        PrintList(list, "Print Sorted List Generics");

        int id = 555;
        if(list.TryGetValue(id, out string name))
        {
            Console.WriteLine($"Get name by id {id} :: {name}");
        }
        else
        {
            Console.WriteLine($"Bad access by id {id}");
        }

        list.RemoveAt(0);
        PrintList(list, "Print Sorted List Generics");
        Console.WriteLine();
        foreach (var item in list.Keys)
        {
            Console.WriteLine($"Code : {item} -- {list[item]}");
        }
    }
    static void PrintList(IDictionary list, string prompt = "")
    {
        Console.WriteLine(new string('=',40));
        Console.WriteLine(prompt);
        foreach (DictionaryEntry item in list)
        {
            Console.WriteLine($"{item.Key,-5} {item.Value,-10}");
        }
    }
    private static void Main(string[] args)
    {
        //DemoSortedList();
        SortedListGen();
    }
}