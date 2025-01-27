using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] lines = { "First line", "Second Line" };
        string fname = "../../../my.txt";
       File.SetAttributes(fname, FileAttributes.Archive);

        if(File.Exists(fname))
        {
            File.Delete(fname);
            Console.WriteLine($"File '{fname}' was deleted \n\n");
        }
        File.WriteAllLines(fname, lines);
        //File.WriteAllText(fname, "Third line \nFourth line\n");
        File.AppendAllText(fname, "Third line \nFourth line\n");

        Console.WriteLine($"Content of file '{fname}' \n{File.ReadAllText(fname)}");
        Console.WriteLine($"Content of file '{fname}' \n{String.Join<string>("\n", File.ReadAllLines(fname))}");

        string fname2 = "../../../copy_my.txt";
        //File.Copy(fname, fname2);// exception якщо файл вже існує fname2
        File.Copy(fname, fname2,true); // дозвіл на перезапис у файл копію (fname2)
        Console.WriteLine($"Content of copy file '{fname2}' \n{File.ReadAllText(fname2)}");

        //FileStream fs = File.Create(fname);
        //StreamWriter sw = File.AppendText(fname);
        var sw = File.CreateText(fname);
        sw.WriteLine("Write something ....");
        sw.Dispose();

        Console.WriteLine();
        Console.WriteLine($"Content of file '{fname}' \n{File.ReadAllText(fname)}");

        File.AppendAllText(fname, "New line");
        Console.WriteLine($"\nContent of file '{fname}' \n{File.ReadAllText(fname)}");
        Console.WriteLine($"Creation time {File.GetCreationTime(fname)}");
        Console.WriteLine($"Last write time {File.GetLastWriteTime(fname)}");

        string fname3 = "../../../third.txt";
        FileInfo fi = new FileInfo(fname3);
        Console.WriteLine($"\n Exists file {fname3} :: {fi.Exists}");
        if(!fi.Exists)
        {
            using (var tw = fi.CreateText())
            {
                tw.WriteLine("It is third file");
            }
        }

        Console.WriteLine($"Content of file {fname3} \n {File.ReadAllText(fname3)}");
        // перемістити файл
        //fi.MoveTo("./third.txt"); // ./ поточна папка

        //Console.WriteLine($"Move to path {Path.Combine(".","third.txt")}");
        Console.WriteLine($"Move to path {Path.Combine(".", fi.Name)}");
        //fi.MoveTo(Path.Combine(".",fi.Name),true);
        Console.WriteLine($"Length of {fi.Name} :: {fi.Length}");
        Console.WriteLine($"Extension of {fi.Name} :: {fi.Extension}");
        Console.WriteLine($"File attributes  of {fname} :: {File.GetAttributes(fname)}");
        File.SetAttributes(fname, FileAttributes.ReadOnly);
        Console.WriteLine($"File attributes  of {fname} :: {File.GetAttributes(fname)}");

    }
}