using Microsoft.AspNetCore.Mvc;

namespace SecondMVC.Controllers
{
    public class PartialViewController : Controller
    {
      //GET:partialView
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are Good friends";
            return View();
        }
    }
}
