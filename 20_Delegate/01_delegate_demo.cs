/*
// визначення типу делегату = тип(компілятор створить клас), який містить у собі посилання на метод(лямбда) з певною сигнатурою
delegate void MsgDelegate(string message); // обєкт MsgDelegate на (static? non static) void - метод з параметром типу string
static class Greeting
{
    internal static void Hello(string name) // цей метод підходить під наш делегат MsgDelegate
    {
        Console.WriteLine($"Hello, {name}");
    }
    internal static void Bye(string name) // цей метод підходить під наш делегат MsgDelegate
    {
        Console.WriteLine($"Bye, {name}");
    }
    internal static void HowAreYou(string name) // цей метод підходить під наш делегат MsgDelegate
    {
        Console.WriteLine($"How are you, {name}");
    }
    internal static void HowAreYou(string name, string surname) // цей метод НЕ підходить під наш делегат MsgDelegate
    {
        Console.WriteLine($"How are you, {name} {surname}");
    }
    internal static void DrawLine(int len, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(new string('*', len));
        Console.ResetColor();
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Greeting.DrawLine(40, ConsoleColor.Red);
        Greeting.Hello("Ivan"); // явний виклик (invoke) стат. метода

        MsgDelegate del = new MsgDelegate(Greeting.Hello); // створили обєкт делегату та повязали з метод (Greeting.Hello);

        Console.WriteLine($"__________ Del references to method : {del.Method}");
        Console.WriteLine($"__________ Del target to object : {del.Target}"); // Target - цільвий обєкт, для якого буде працювати метод (зараз null, бо static метод)
        del.Invoke("Maria"); //  неявний виклик static метода через делегат з фактичним параметром

        del("Ivan");

        del = Greeting.HowAreYou;
        Console.WriteLine($"__________ Del references to method : {del.Method}");
        Console.WriteLine($"__________ Del target to object : {del.Target}");
        *//*del = null;
        if(del != null)
            del.Invoke("Pasha");*//*
        del?.Invoke("Olia");

        Greeting.DrawLine(40, ConsoleColor.Green);
        Console.WriteLine();
        MsgDelegate group = Greeting.Hello;
        group += Greeting.HowAreYou;
        group += Greeting.HowAreYou;
        group += Greeting.Bye; // це груповий(мультиадресний, multiaddress, multicast) делегат, містить в собі масив посилань на методи

        group("Dmytro");
        Greeting.DrawLine(40, ConsoleColor.Green);
        Console.WriteLine();
        group = new MsgDelegate(Greeting.Hello) + Greeting.HowAreYou;
        group("Vitaliy");
        Greeting.DrawLine(40, ConsoleColor.Green);
        Console.WriteLine();
        group -= Greeting.HowAreYou;
        group("Vitaliy");


    }
}*/