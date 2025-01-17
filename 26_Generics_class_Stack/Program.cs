internal class Program
{
    private static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>(10);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        foreach (int i in stack)
        {
            Console.WriteLine(i);
        }
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Peek());
            stack.Pop();
        }
    }
}