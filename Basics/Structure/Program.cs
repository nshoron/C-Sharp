using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class Program
    {
        struct Book
        {
            public string title;
            public string author;
            public int numberOfPages;
        };

        static void Main(string[] args)
        {
            Book b1;
            Book b2 = new Book();

            b1.title = "C# Programming";
            b1.author = "Cecilia";
            b1.numberOfPages = 5995;

            b2.title = "C# Programming";
            b2.author = "Hansen";
            b2.numberOfPages = 4995;

            Console.WriteLine("Book 1 Details ....................");
            Console.WriteLine(" Title : "+b1.title);
            Console.WriteLine("Author : "+b1.author);
            Console.WriteLine("Pages  : "+b1.numberOfPages);

            Console.WriteLine("Book 2 Details ....................");
            Console.WriteLine(" Title : " + b2.title);
            Console.WriteLine("Author : " + b2.author);
            Console.WriteLine("Pages  : " + b2.numberOfPages);

            Console.ReadKey();
        }
    }
}
