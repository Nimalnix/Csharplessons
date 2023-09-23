using System.Net.WebSockets;

namespace libraryA
{
    public class Book
    {
        public String Title=string.Empty;
        public String Author=string.Empty;
        public String Genre=string.Empty;
        public DateTime DateofPublish;
        public int BookPrice;
        public int totalpages=300;
        public Book()
        {
            Console.WriteLine( "book obj is created");
        }
            public void OpenBook()
        {
            Console.WriteLine( "Book is open");
        }
        public void BookMarkPage(int PageNo)
        {
            Console.WriteLine( $"Page no:{PageNo} Bookmarked");

        }
        public int Getcurrentpage()
        {
            Random rnd = new Random();
            return rnd.Next(  totalpages );
        }


    }
}