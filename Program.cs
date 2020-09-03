using System.Collections.Generic;
using System;

namespace bookproject
{
    class Program
    {
        static void Main(string[] args)
        { 

            List<Book> fantasyBooks = BookFile.GetBooks();

            foreach(Book aBook in fantasyBooks)
            {
                Console.WriteLine($"{aBook.Title} has {aBook.Pages} pages");    
            }
            
        }
    }
}
