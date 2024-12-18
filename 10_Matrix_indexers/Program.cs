using _10_Matrix_indexers;

internal class Program
{
    private static void Main(string[] args)
    {
        Matrix matrix = new Matrix();
        Console.WriteLine(matrix);
        matrix[0,0] = 11; 
        matrix[0,1] = 12; 
        matrix[1,0] = 13; 
        matrix[1,1] = 14;
        Console.WriteLine(matrix);
    }
}