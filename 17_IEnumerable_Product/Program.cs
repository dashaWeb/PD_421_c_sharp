using _17_IEnumerable_Product;

internal class Program
{
    private static void Main(string[] args)
    {
        Shop shop = new Shop();
        Item apple = new Item() { Name = "Apple", Price = 30};
        Item orange = new Item() { Name = "Orange", Price = 50};
        Item blueberry = new Item() { Name = "Blueberry", Price = 60};
        Item plum = new Item() { Name = "Plum", Price = 70};

        shop.AddItem(apple);
        shop.AddItem(orange);
        shop.AddItem(blueberry);
        shop.AddItem(plum);

        Console.WriteLine(shop);

        Console.WriteLine("---------------- Foreach Enumerator ----------------");
        foreach (var item in shop)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------- Foreach GetReverse() ----------------");
        foreach (var item in shop.GetReverse())
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("---------------- Foreach GetItemsLimit() ----------------");
        foreach (var item in shop.GetItemsLimit(60))
        {
            Console.WriteLine(item);
        }
    }
}