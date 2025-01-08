using _14_Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        Duck duck = new Duck() { Weight = 4};
        Console.WriteLine($"Duck weight :: {duck.Weight}");
        duck.Move();
        duck.Fly();
        duck.Swim();
        Console.WriteLine("----------- Duck as IMove ----------");
        IMove move = duck;
        move.Move();
        Console.WriteLine($"Speed :: {move.Speed}");
        Console.WriteLine("----------- Duck as IFly ----------");
        IFly fly = duck;
        fly.Fly();
        Console.WriteLine($"Speed :: {fly.Speed}");
        Console.WriteLine("----------- StreamerDuck as IFly ----------");
        StreamerDuck streamer = new StreamerDuck();
        streamer.Fly();
        Console.WriteLine("----------- Array of ducks fly ----------");
        IFly[] ducks = { duck, streamer };
        foreach (var item in ducks)
        {
            item.Fly();
        }
    }
}