using System.Collections.Generic;
using System;

namespace bookproject
{
    class Program
    {
        static void Main(string[] args)
        { 

            List<Book> fantasyBooks = BookFile.GetBooks();

            foreach(Book books in fantasyBooks)
            {
                Console.WriteLine($"{books.Title} has {books.Pages} pages");    
            }
        }
    }
}
