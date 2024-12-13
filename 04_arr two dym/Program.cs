internal class Program
{
    static void print(int[,] arr)
    {
        /*foreach (var item in arr)
        {
            Console.Write($"{item,-20}");
        }
        Console.WriteLine();*/

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j],-20}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void fill(int[][] arr)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++) // по рядках
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                arr[i][j] = rnd.Next(1, 10);
            }
        }
    }
    static void print(int[][] arr)
    {
        /*for (int i = 0; i < arr.Length; i++) // по рядках
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write($"{arr[i][j],-20}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();*/
        foreach (int[] row in arr) {
            foreach (var item in row)
            {
                Console.Write($"{item,-20}");
            }
            Console.WriteLine();
        }
    }
    static int[][] create(int row)
    {
        int[][] arr = new int[row][];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new int[new Random().Next(5, 10)];
        }
        return arr;
    }
    static void SwapRows(int[][] arr, int row1, int row2)
    {
        if(row1 >= 0 && row2 >= 0 && row1 < arr.Length && row2 < arr.Length)
        {
            int[] tmp = arr[row1]; // посилання на row1
            arr[row1] = arr[row2];
            arr[row2] = tmp;
        }
    }
    static void MathRows(int[][] arr)
    {
        foreach (int[] row in arr)
        {
            Console.WriteLine($"Sum :: {row.Sum()}");
            Console.WriteLine($"Min :: {row.Min()}");
            Console.WriteLine($"Max :: {row.Max()}");
            Console.WriteLine($"Avg :: {row.Average()}");
        Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        /*int[,] arr = new int[3, 4]
        {
            {1,2,3,4 },
            {10,20,30,40 },
            {100,200,300,400 }
        };
        Console.WriteLine(arr.Length);
        print(arr);*/

        /*int[][] arr = new int[4][];
        arr[0] = new int[] { 1, 2, 3 };
        arr[1] = new int[] { 1, 2, 3, 4};
        arr[2] = new[] { 1, 2, 3, 4, 5 };
        arr[3] = new[] { 1, 2, 3, 4, 5 };*/

        int[][] arr = create(3);

        fill(arr);
        print(arr);
        Console.WriteLine();
        SwapRows(arr,0,arr.Length-1);
        print(arr);
        MathRows(arr);
    }
}