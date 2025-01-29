using _38_Linq_to_Collection_with_object;


internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> books = new List<Book>
            {
                new Book{Title = "Web Development", Author = "Aki Iskandar ", Category = Book.CategoryBook.Web, Year = 2019, Price=39.99f },
                new Book{Title = "Bootstrap 4 ", Author = "Jacob Lett", Category = Book.CategoryBook.Web, Year = 2018, Price=31.5f },
                new Book{Title = "Professional C# 7 ", Author = "Christian Nagel ", Category = Book.CategoryBook.NET, Year = 2018, Price=60.0f },
                new Book{Title = "Pro C# 7: With .NET", Author = "Andrew Troelsen", Category = Book.CategoryBook.NET, Year = 2017, Price=39.0f },
                new Book{Title = "C# 7.0 in a Nutshell", Author = "Jozeph Albahari", Category = Book.CategoryBook.NET, Year = 2017, Price=79.99f },
                new Book{Title = "harry Potter", Author = "Rowling", Category = Book.CategoryBook.Children, Year = 2017, Price=19.99f }

            };

        var res = from book in books
                  where book.Year <= 2018
                  select book;
        PrintBooks(res, "Print Book (year <=2018)");
        res = from book in books
              where book.Year <= 2018
              orderby book.Author
              select book;
        PrintBooks(res, "Print Book (year <=2018) sorted");
        res = from book in books
              where book.Year <= 2018
              orderby book.Author descending
              select book;
        PrintBooks(res, "Print Book (year <=2018) sorted desc");
        var title = from book in books
              where book.Year <= 2018
              orderby book.Author descending
              select book.Title;
        PrintBooks(title, "Print Book (year <=2018) sorted desc (select title)");

        var max_price = books.Max(x => x.Price);
        Console.WriteLine($"Max price book {max_price}");
        var res_2 = books.Where(b => b.Category == Book.CategoryBook.NET).OrderBy(x => x.Price);
        PrintBooks(res_2, "Print Book (CategoryBook.NET) sorted ");

        var res_3 = from b in books group b by b.Category; // Key - name category
        Console.WriteLine();
        foreach (var item in res_3)
        {
            Console.WriteLine($"__________{item.Key}____________ Count {item.Count()}__________Max Price {item.Max(x=>x.Price)}");
            foreach (var b in item)
            {
                Console.WriteLine(b);
            }
        }
    }

    static void PrintBooks<T>(IEnumerable<T> books, string text = "")
    {
        Console.WriteLine($"{(text.Length == 0 ? "" : "\n\t")} {text}");
        foreach (var item in books)
        {
            Console.WriteLine(item);
        }
    }
}