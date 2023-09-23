using FirstMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing;

namespace FirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();//inbulid method it will search for method with  name html file called index
        }
        public IActionResult sayHello(String name)
        {
            if (String.IsNullOrEmpty(name))
            {
                ViewData["v1"] = "Name is empty";
            }
            else

                ViewData["v1"] = name;

            return View();
        }
        public IActionResult Add(int x, int y)
        {
            int result = x + y;

            ViewData["result"] = result;

            return View();
        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x * y;

            ViewData["result"] = result;

            return View("add");
        }
        public IActionResult Divide(int x, int y)
        {
            int result = x / y;

            ViewData["result"] = result;

            return View("add");
        }
        public IActionResult DoLogin(String txtuser, String txtpwd)
        {
            ViewData["uservalue"] = $"{txtuser},{txtpwd}";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddnewBook()
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult savenewBook(Book ebook)
        {
            String fname = @"C:\temp\book.csv";
            string strBook = $"{ebook.BookID},{ebook.Title},{ebook.AuthorName},{ebook.Cost}";
            using (StreamWriter sw = new StreamWriter(fname, true))
            {
                sw.WriteLine(strBook);
            }
            return View(ebook);
        }
        public IActionResult ListAllBook()
        {
            string fname = @"C:\temp\book.csv";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fname))
            {
                string strBook = $"{sr.ReadLine()}";
                string[] data = strBook.Split(',');
                Book book = Stringtobook(data, new Book());
                list.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(",");
                    book = Stringtobook(data, new Book());
                    list.Add(book);
                }
            }
            return View(list);
        }
        private Book Stringtobook(string[] data, Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;
        }

        public IActionResult AddAuthor()
        {
            Author author = new Author();
            return View(author);
        }
        public IActionResult SavenewAuthor(Author pAuthor)
        {
            string fname = @"C:\temp\Authors.csv";
            string strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.NoOfBookPublished},{pAuthor.Royalty},{pAuthor.DOB}";
            using (StreamWriter s = new StreamWriter(fname, true))
            {
                s.WriteLine(strAuthor);
            }
            return View(pAuthor);





        }
        private Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.NoOfBookPublished = int.Parse(data[2]);
            author.Royalty = data[3];
            author.DOB = DateTime.Parse(data[4]);
            return author;



        }
        public IActionResult ListAllAuthor()
        {
            string fname = @"c:\temp\Authors.csv";
            List<Author> lists = new List<Author>();
            using (StreamReader s = new StreamReader(fname))
            {
                string strAuthor = $"{s.ReadLine()}";
                string[] data = strAuthor.Split(',');
                Author author = StringToAuthor(data, new Author());
                lists.Add(author);
                while (!s.EndOfStream)
                {
                    strAuthor = $"{s.ReadLine()}";
                    data = strAuthor.Split(",");
                    author = StringToAuthor(data, new Author());
                    lists.Add(author);



                }




            }
            return View(lists);
        }
    }
}