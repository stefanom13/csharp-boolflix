using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class ContenutoVideoController : Controller
    {
        // GET: ContenutoVideoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContenutoVideoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContenutoVideoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContenutoVideoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ContenutoVideoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContenutoVideoController/Edit/5
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

        // GET: ContenutoVideoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContenutoVideoController/Delete/5
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
