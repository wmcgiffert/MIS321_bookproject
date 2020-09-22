using System.IO;
using System.Collections.Generic;

namespace bookproject
{
    public class BookFile
    {
        public static List<Book> GetBooks()
        {
            //Creates a list of books
            List<Book> fantasyBooks = new List<Book>();

            //creates a file that reads "input.txt"
            StreamReader inFile = new StreamReader("input.txt");

            //Priming Statement. Reads a line in from inFile and sets it to a string
            string line = inFile.ReadLine();
            
            //Reading Statement. While loop that continues as long as line doesnt get a null
            while(line != null)
            {
                // creates an array that splits the string line by #
                string[] temp = line.Split("#");
                //creates a var for pages since it has to be Parsed
                int pages = int.Parse(temp[2]);
                //adds a new book to fantasyBooks List
                fantasyBooks.Add(new Book(){Title = temp[0], Author = temp[1], Pages = pages});
                //Reads the next line in the txt file
                line = inFile.ReadLine();            
            }

            //closes file
            inFile.Close();
            //returns the list
            return fantasyBooks;

        }
        
    }
}