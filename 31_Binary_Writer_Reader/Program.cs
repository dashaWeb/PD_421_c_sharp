using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string fname = "../../../data.dat";
        /* using (BinaryWriter br = new BinaryWriter(new FileStream(fname, FileMode.Create)))
         {
             string test = "Test - line Тестоіий рядок";
             double valueD = -23.254;
             int valueI = 45621;
             int[] arr = { 10, 20, 30, 40, 50 };


             br.Write(test);
             br.Write(valueD);
             br.Write(valueI);

             br.Write(arr.Length);
             foreach (var item in arr)
             {
                 br.Write(item);
             }
         }*/
        Console.OutputEncoding = Encoding.Unicode;
        using(BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open)))
        {
            string readStr = br.ReadString();
            Console.WriteLine($"Read string :: {readStr}");
            Console.WriteLine($"Read double :: {br.ReadDouble()}");
            Console.WriteLine($"Read int    :: {br.ReadInt32()}");
            Console.WriteLine($"Recovered Array :: ");
            int[] arr = new int[br.ReadInt32()];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = br.ReadInt32();
            }
            Console.WriteLine(String.Join<int>("\t",arr));
        }

    }
}