using System;

namespace bookproject
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Book[] fantasyBooks = new Book[50];
            fantasyBooks[0] = new Book(){Title = "The Final Empire", Author = "Brandon Sanderson", PageNums = 500};
            fantasyBooks[1] = new Book(){Title = "Well of Ascension", Author = "Brandon Sanderson", PageNums = 500};
            fantasyBooks[2] = new Book(){Title = "The Hero of Ages", Author = "Brandon Sanderson", PageNums = 500};

            for(int i = 0; i<3; i++)
            {
                Console.WriteLine($"{fantasyBooks[i].Title} has {fantasyBooks[i].PageNums} pages");    
            }


            
            




        }
    }
}
