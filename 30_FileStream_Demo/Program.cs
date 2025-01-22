using System.Text;

internal class Program
{
    static void WriteAndReadBytes()
    {
        string fname = "bytes.dat";
        using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate))
        {
            byte byteValue = 65; // A
            byte[] buffer = { 10, 11, 12, 13, 14, 15 };
            fs.WriteByte(byteValue);
            fs.Write(buffer, 0, buffer.Length);

            //fs.Position= 0;
            fs.Seek(0, SeekOrigin.Begin);
            //fs.Seek(-2, SeekOrigin.End);
            Console.WriteLine($"File size in bytes :: {fs.Length}");
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            Console.WriteLine($"Read array :: {String.Join<byte>("\t", bytes)}");
        }
        //fs.Close();
        //fs.Disponse()
    }
    static void WriteString(string value, string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            byte[] bytes = Encoding.Unicode.GetBytes(value);
            fs.Write(bytes, 0, bytes.Length);
        }
    }

    static string ReadString(string path)
    {
        string value = String.Empty;
        using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes,0, bytes.Length);
            value = Encoding.Unicode.GetString(bytes);
        }
        return value;
    }

    static void WriteInt(int value, string path) 
    {
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            byte[] bytes =  BitConverter.GetBytes(value);
            //Console.WriteLine(String.Join<byte>("\t",bytes));
            fs.Write(bytes,0, bytes.Length);
        }
    }
    static int ReadInt(string path)
    {
        int value = 0;
        using(FileStream fs = new FileStream(path,FileMode.Open, FileAccess.Read))
        {
            byte[] bytes = new byte[sizeof(int)];
            fs.Read(bytes,0, bytes.Length);
            value = BitConverter.ToInt32(bytes,0);
        }
        return value;
    }

    static void WriteIntToFS(int value, FileStream fs)
    {
        byte[] bytes = BitConverter.GetBytes(value);
        fs.Write(bytes, 0, bytes.Length);
    }
    private static void Main(string[] args)
    {
        string fname = "../../string.dat";
        //WriteString("Hello", fname);
        //Console.WriteLine($"Read file string :: {ReadString(fname)}");
        string fnumber = "../../../number.dat";
        //WriteInt(-10789,fnumber);
        //Console.WriteLine($"Read file Int :: {ReadInt(fnumber)}");

        using (FileStream fs = new FileStream(fnumber, FileMode.Create))
        {
            int[] arr = { 5, 7, 8 };
            foreach (var item in arr)
            {
                WriteIntToFS(item, fs);
            }
        }
    }
}