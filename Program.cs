using System.Collections.Generic;
using System;

namespace bookproject
{
    class Program
    {
        static void Main(string[] args)
        { 

            List<Book> fantasyBooks = new List<Book>();

            fantasyBooks = BookFile.GetBooks();

            
            Console.WriteLine("For Loop:");
            for(int i = 0; i < fantasyBooks.Count; i++)
            {
                Console.WriteLine($"{fantasyBooks[i].Title} has {fantasyBooks[i].Pages} pages.");

            }

            Console.WriteLine();
            Console.WriteLine("Foreach Loop:");

            foreach(Book books in fantasyBooks)
            {
                Console.WriteLine($"{books.Title} has {books.Pages} pages");    
            }
        }
    }
}
