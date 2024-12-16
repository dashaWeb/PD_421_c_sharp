using _07_Static___class;

internal class Program
{
    // static class 
    // 1) може містити лише статичні поля та методи
    // 2) не можна створити екземпляр
    static class AreaShapes
    {
        const double PI = 3.14; // константа у C# є неявно статична
        public static double TrianArea(double height, double side)
        {
            return 0.5 * height * side;
        }
        public static double CircleArea(double radius)
        {
            return PI * Math.Pow(radius, 2);
        }
    }

    private static void Main(string[] args)
    {
        //AreaShapes test = new AreaShapes();
        //Console.WriteLine($"Trian area :: {AreaShapes.TrianArea(10,20)}");
        Console.WriteLine("Main started .... ");
        Console.WriteLine($"Last id :: {Employee.LastId}");
        Employee emp1 = new Employee() { Name = "Denis", Birth = DateTime.Parse("30/05/2000"), Position = Position.QA};
        Console.WriteLine(emp1);
        Console.WriteLine($"Age :: {emp1.Age}");

        Employee emp2 = new Employee()
        {
            Name = "Ivan",
            Birth = new DateTime(2005, 12, 5),
            Position = Position.Manager,
        };
        Console.WriteLine(emp2);
        Console.WriteLine($"Age :: {emp2.Age}");
        Console.WriteLine($"Same position :: {Employee.SamePOsition(emp1,emp2)}");
    }
}