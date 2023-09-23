using FirstMvcApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcApp.Controllers
{
    public class movieController : Controller
    {
        // GET: movieController
        public ActionResult Index()
        {

            List<movie> list = movieDbRepository.GetMovieList();
            return View(list);
        }



        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            movie enitity = movieDbRepository.GetMovieById(id);
            return View(enitity);
        }



        // GET: MovieController/Create
        public ActionResult Create()
        {
            movie enitity = new movie();
            return View(enitity);
        }



        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, movie pmovie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    movieDbRepository.AddNewEnitity(pmovie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            movie enitity = movieDbRepository.GetMovieById(id);
            if (enitity != null)
            {
                return View(enitity);
            }
            return View(enitity);
        }



        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, movie pmovie)
        {
            try
            {
                movieDbRepository.UpdateMovie(pmovie);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            movie enitity = movieDbRepository.GetMovieById(id);
            if (enitity != null)
            {
                return View(enitity);
            }
            return View(enitity);
        }



        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection, movie pmovie)
        {
            try
            {
                movieDbRepository.DeleteMovie(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}