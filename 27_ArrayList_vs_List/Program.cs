using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // неузагальнені - елементи типу object
        // непродуктивно для value - типів (boxing - unboxing)

        ArrayList al = new ArrayList() { 10, 3.4,"Test",true,900};
        al[0] = 10.7;
        Console.WriteLine($"Capacity :: {al.Capacity}");
        Console.WriteLine($"Count    :: {al.Count}");
        PrintList( al ,"Print Array List");

        al.Add( 10 );
        al.AddRange(new int[] { 1,2,3,4} );
        PrintList( al ,"Print Array List after add");
        Console.WriteLine($"Capacity :: {al.Capacity}");
        Console.WriteLine($"Count    :: {al.Count}");
        al.Insert(0, 222);
        al.InsertRange(5, new object[] { "line 1", "line 2",1,2,3,4,5,6 });
        PrintList( al ,"Print Array List after insert");
        Console.WriteLine($"Capacity :: {al.Capacity}");
        Console.WriteLine($"Count    :: {al.Count}");
        al.Remove("Test");
        al.RemoveAt(0);
        PrintList( al ,"Print Array List after remove test");
        al.RemoveRange(0, 5);
        PrintList( al ,"Print Array List after remove test");
        al.Clear();
        Console.WriteLine($"Capacity :: {al.Capacity}");
        Console.WriteLine($"Count    :: {al.Count}");

        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            al.Add((char)rnd.Next(65, 91));
        }
        PrintList(al, "Print Array List of char");

        Console.Clear();

        List<string> color = new List<string>()
        {
            "red","gold","blue","purple","yellow","cyan","magenta","lime"
        };
        PrintList(color, "Print List");

        color.AddRange(new string[] {"blue","white","black" });
        PrintList(color, "Print List");
        color.InsertRange(0, new string[] { "brown", "pink" });
        PrintList(color, "Print List");

        color.Remove("cyan");
        PrintList(color, "Print List");
        //color.RemoveAll(w => w.Contains('o'));
        color.Sort();
        PrintList(color, "Print List sort");
        color.Sort((s1,s2) => -s1.Length.CompareTo(s2.Length));
        PrintList(color, "Print List sort by length");
    }
    static void PrintList(IEnumerable list, string text = "")
    {
        Console.WriteLine(text);
        foreach(var item in list)
        {
            Console.Write($"{item,10}");
        }
        Console.WriteLine();
    }
}