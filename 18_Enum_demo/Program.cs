enum Color : byte
{
    Red = 4, Blue = 1, White = 15, Black = 0 
} // = default int

internal class Program
{
    private static void Main(string[] args)
    {
        // Enum - базовий тип (value type)

        Color color = Color.Red;
        Console.WriteLine($"\n{color} = {(byte)color}");
        //Console.WriteLine("Input color :: Red = 4, Blue = 1, White, Black");
        /*color = (Color)Enum.Parse(typeof(Color), Console.ReadLine()!, true);
        Console.WriteLine($"\n{color} = {(byte)color}");*/

        /*if(Enum.TryParse<Color>(Console.ReadLine(),out color))
        {
            Console.WriteLine("-------- Test TryParse ------------");
            Console.WriteLine($"\n{color} = {(byte)color}");
        }*/

        Console.WriteLine("\n ---------------------------- GetNames() -----------------------");
        string[] names =  Enum.GetNames( typeof( Color ) );
        //string[] names =  Enum.GetNames( typeof( ConsoleColor ) );
        foreach( string name in names )
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\n ---------------------------- GetValues() -----------------------");
        Color[] value = (Color[])Enum.GetValues(typeof(Color));
        foreach (var item in value)
        {
            Console.WriteLine($"{item} = {(byte)item}");
        }
    }
}