using System;

namespace Defining
{

    class Program
    {
        static void Main(string[] args)
        {

            Book b1 = new Book("Werner", "Nice book", 405);
            Book b2 = new Book("Jeanette", "New book Title", 708);

            Console.WriteLine(b1.Description);
            Console.WriteLine(b2.Description);

            b1.Author = "Jan";
            b1.ISBN = "1239123";
            b1.Price = 34.5m;

            Console.WriteLine(b1.Description);
            Console.WriteLine(b1.ISBN);
            Console.WriteLine(b1.Price);
        }
    }
}