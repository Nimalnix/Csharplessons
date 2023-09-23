using FirstMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcApp.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<int,Author> list=AuthorRepository.GetAuthorDictionary();
            if(list!=null && list.Count>0)
            {
                return View("AuthorList",list.Values.ToList());
            }
            return View();
        }
        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            Author author=AuthorRepository. FindAuthorById(id);
            if (author != null)
            {
                return View(author);
            }
            return RedirectToAction("Index");

        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            Author author=new Author();
            return View(author);
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Author pAuthor)
        {
            try
            {
                AuthorRepository .SaveToFile(pAuthor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            Author author = AuthorRepository.FindAuthorById(id);
            if(author!=null)
            {
                return View(author);
            }
            return View(author);
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Author pAuthor)
        {
            try
            {
                AuthorRepository.UpdateAuthorToFile(pAuthor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            Author author=AuthorRepository.FindAuthorById(id);
            if (author!=null)
            {
            return View(author);
            }
            
            return View(author);
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection,Author pAuthor)
        {
            try
            {
                AuthorRepository.RemoveAuthor(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
