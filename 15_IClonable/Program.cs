using _15_IClonable;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student("Sasha",10,5,8,10,12,11,3);
        Console.WriteLine($"Origin :: {student}");

        Student clone = student.Clone() as Student;
        Console.WriteLine();
        Console.WriteLine($"Origin :: {student}");
        Console.WriteLine($"Clone  :: {clone}");

        clone[0] = 12;
        clone[1] = 12;
        clone.Name = "Olia";
        Console.WriteLine();
        Console.WriteLine($"Origin :: {student}");
        Console.WriteLine($"Clone  :: {clone}");
    }
}