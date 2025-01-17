class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int CompareTo(Person? other)
    {
        return this.Age.CompareTo(other.Age);
    }
    virtual public void Busy()
    {
        Console.WriteLine($"Person {Name} is busy .....");
    }
    public override string ToString()
    {
        return $"Name :: {Name,-10} Age :: {Age}";
    }
}
class Employee : Person
{
    public override void Busy()
    {
        Console.WriteLine($"Employee {Name} is working");
    }
}
class Student : Person { }
internal class Program
{
    // contrains - обмеження на тип 
    static void CheckBusy<T>(T person) where T : Person
    {
        person.Busy();
    }
    static T Max<T>(T one, T two) where T : IComparable<T>
    {
        return one.CompareTo(two) > 0 ? one : two;
    }
    private static void Main(string[] args)
    {
        /*int value = 11;
        double valueD = 2.5;
        string line = "Lorem ipsum";
        object[] test = {value,valueD,line }; // boxing
        foreach (object obj in test)
        {
            if(obj is int)
                Console.WriteLine((int)obj + 1); // unboxing

        }*/
        // <>

        int a = 10, b = 15;
        Console.WriteLine($"Max {a}, {b} = {Max(a,b)}");

        string one = "book", two = ".net";
        Console.WriteLine();
        Console.WriteLine($"Max {one}, {two} = {Max(one,two)}");

        Person p1 = new Person() { Name = "Oleg", Age = 20 };
        Person p2 = new Person() { Name = "Ivanna", Age = 25 };
        Console.WriteLine();
        Console.WriteLine($"Max {p1}, {p2} = {Max(p1,p2)}");

        Console.WriteLine();
        CheckBusy<Person>(p1);
    }
}