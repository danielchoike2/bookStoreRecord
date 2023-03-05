using System;
namespace Demo
{
    class Program
    {
        public record Bookstore
        {
            public int ID { get; init; }
            public  string Title { get; init; }
            public string Author { get; init; }  
            public double Price { get; init; }
            public Bookstore()
            {
                ID = 0;
                Title= string.Empty;    
                Author = string.Empty;  
                Price = 0;

            }
            public Bookstore(int id, string title, string author, double price)
            {
                ID = id;
                Title = title;
                Author = author;
                Price = price;

            }
        }
        public static void Main()
        {
            Bookstore bookstore1 = new(1, "The Hobbit", "J.R.R. Tolkien", 20.50);
            Console.WriteLine(bookstore1);
            Bookstore bookstore2 = new(2, "It", "Steven King", 15.99 );
            Console.WriteLine(bookstore2);
            Bookstore bookstore3 = new(3, "Dune", "Frank Herbert", 17.99);
            Console.WriteLine(bookstore3);
        }
    }
}