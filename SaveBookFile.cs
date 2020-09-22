using System.Threading;
using System.IO;
using System.Collections.Generic;

namespace bookproject
{
    public class SaveBookFile
    {
        public static void SaveBook(List<Book> book)
        {
            StreamWriter outFile = new StreamWriter("");

            foreach(Book books in book)
            {
                outFile.WriteLine(book.ToString());
            }

            outFile.Close();

        }
    }
}