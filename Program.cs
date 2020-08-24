using System;

namespace bookproject
{
    class Program
    {
        static void Main(string[] args)
        {

            Book myBook = new Book(){Title = "Mistborn 1", Author = "Brandon Sanderson"};

            Console.WriteLine(myBook.Title);
            Console.WriteLine(myBook.Author);



        }
    }
}
