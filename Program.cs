using System.Collections.Generic;
using System;

namespace bookproject
{
    class Program
    {
        static void Main(string[] args)
        { 

            List<Book> fantasyBooks = BookFile.GetBooks();

            for(int i = 0; i<3; i++)
            {
                Console.WriteLine($"{fantasyBooks[i].Title} has {fantasyBooks[i].Pages} pages");    
            }
            
        }
    }
}
