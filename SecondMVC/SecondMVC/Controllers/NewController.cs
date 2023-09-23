using Microsoft.AspNetCore.Mvc;

namespace SecondMVC.Controllers
{
    public class NewController : Controller
    {
        //GET:
        public IActionResult Start()
        {
            return View();
        }
    }
}
