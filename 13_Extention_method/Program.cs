static class IntExtension
{
    public static int CountDigits(this int number)
    {
        return Math.Abs(number).ToString().Length;
    }
}
static class ArrayExtension
{
    public static int SumPositive(this int[] arr)
    {
        return Array.FindAll(arr, e => e > 0).Sum();
    }
}
internal class Program
{
    /*
     Extension method - метод розширювати поведінку(клас, структура і т.д.)
    1) визначити статичний метод у статичному класі
    2) перший параметр = this type
    3) викликати
    */
    
    private static void Main(string[] args)
    {
        int value = -455521455;
        Console.WriteLine(value.CountDigits());
        int[] arr = new int[] { 1,-5,-7,10,11,-2};
        Console.WriteLine(arr.SumPositive());
       
    }
}