using _24_EventHabdler_args;

internal class Program
{
    private static void Main(string[] args)
    {
        // Publisher
        Company softServe = new Company() { Name = "SoftServe" };
        Company honeyComb = new Company() { Name = "HoneyComb" };

        // subscriber
        Interviwer ann = new Interviwer() { Name = "Ann" };
        Interviwer ivan = new Interviwer() { Name = "Ivan" };

        softServe.NewPosition += ann.DoSomething;
        softServe.NewPosition += ivan.DoSomething;

        honeyComb.NewPosition += ann.DoSomething;
        honeyComb.NewPosition += ivan.DoSomething;

        softServe.AddPosition("Intern C++");
        Console.WriteLine();
        Console.ReadKey();
        honeyComb.AddPosition("Junior .NET");

        honeyComb.NewPosition -= ann.DoSomething;

        Console.ReadKey();
        Console.WriteLine();
        honeyComb.AddPosition("Middle Frontend");
    }
}