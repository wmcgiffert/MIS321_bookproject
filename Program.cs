using System;

namespace bookproject
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Book[] fantasyBooks = BookFile.GetBooks();

            for(int i = 0; i<3; i++)
            {
                Console.WriteLine(value: $"{fantasyBooks[i].Title} has {fantasyBooks[i].Pages} pages");    
            }
            
        }
    }
}
