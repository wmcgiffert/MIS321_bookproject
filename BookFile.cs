using System.IO;
using System.Collections.Generic;

namespace bookproject
{
    public class BookFile
    {
        public static List<Book> GetBooks()
        {
            List<Book> fantasyBooks = new List<Book>();
            StreamReader inFile = new StreamReader("input.txt");
            
            string line = inFile.ReadLine(); //Primming Read
            while(line !=null)
            {
                string[] temp = line.Split("#");
                int pages = int.Parse(temp[2]);
                fantasyBooks.Add(new Book(){Title = temp[0], Author = temp[1], Pages = pages});
                line = inFile.ReadLine(); //update read
            }

            inFile.Close();
            return fantasyBooks;
        }
        
    }
}