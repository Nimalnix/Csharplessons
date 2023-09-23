using FirstMvcApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcApp.Controllers
{
    public class empController : Controller
    {
        // GET: empController
        public ActionResult Index()
        {
            List<Emp> empList=EmpDbRepository.GetEmpList();
            return View(empList);
        }

        // GET: empController/Details/5
        public ActionResult Details(int id)
        {
            if(id<=0)
            {
                return RedirectToAction("Index");
            }
            Emp emp=EmpDbRepository.GetEmpById(id);
            return View(emp);
        }

        // GET: empController/Create
        public ActionResult Create()
        {
            Emp emp=new Emp();
            return View(emp);
        }

        // POST: empController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Emp pEmp)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    EmpDbRepository.AddNewEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: empController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: empController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: empController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: empController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
