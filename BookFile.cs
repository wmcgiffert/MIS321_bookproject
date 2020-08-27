using System.IO;
namespace bookproject
{
    public class BookFile
    {
        public static Book[] GetBooks()
        {
            Book[] fantasyBooks = new Book[50];
            int count = 0;

            StreamReader inFile = new StreamReader("input.txt");
            
            string line = inFile.ReadLine(); //Primming Read

            while(line !=null)
            {
                string[] temp = line.Split("#");
                int pages = int.Parse(temp[2]);
                fantasyBooks[count] = new Book(){Title = temp[0], Author = temp[1], Pages = pages};
                count++;
                line = inFile.ReadLine(); //update read
            }

            inFile.Close();
            return fantasyBooks;
        }
        
    }
}