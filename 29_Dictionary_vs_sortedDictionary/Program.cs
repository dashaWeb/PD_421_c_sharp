using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            ["Hello"] = "привіт",
            ["bye"] = "бувай",
            ["program"] = "програма",
            ["developer"] = "програмічт, розробник",
        };
        Console.OutputEncoding =  Encoding.UTF8;
        dic.Remove("Hello");
        foreach (var item in dic)
        {
            Console.WriteLine($"{item.Key,-10} {item.Value}");
        }

        SortedDictionary<string, string> dicSort = new SortedDictionary<string, string>(dic);
        Console.WriteLine("Sorted");
        foreach (var item in dicSort)
        {
            Console.WriteLine($"{item.Key,-10} {item.Value}");
        }
       
    }
}