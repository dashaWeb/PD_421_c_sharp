internal class Program
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string getName() => Name;
    }
    private static void Main(string[] args)
    {
        // value types => int, double, enum, struct, bool, char, byte
        // reference types => class, array, string, BuilderString, delegate
        //string str = null;
        //int value = null;
        //Console.WriteLine(default(string) == null);
        //Console.WriteLine(default(int[])  == null);
        //Console.WriteLine(default(int));
        //Console.WriteLine(default(bool));
        //str = "Text text";
        /*if (str != null)
        {
            Console.WriteLine(str);
        }
        else { Console.WriteLine("Default text"); }*/

        //str = "Text text";
        //Console.WriteLine(str != null ? str : "Default text");
        //Console.WriteLine(str ?? "Defaul text");

        Person person = new Person() { Name = "Denis" };
        //Console.WriteLine(person.Name??"None");
        //Person person = null;
        //Console.WriteLine(person?.getName());
        Console.WriteLine($"Str length --> {person.Name?.Length ?? -1}");
        string str = null;
        str = "string test ";
        Console.WriteLine($"Replace :: {str?.Replace('s', '@')}");
        int[] arr = null;
        Console.WriteLine(arr?[0]);
        arr??= new int[6] {1,2,3,4,5,6 };
        Console.WriteLine(arr?[0]);

        Nullable<int> i =  null;
        int?j = null;
        Console.WriteLine(j.GetValueOrDefault());
    }
}