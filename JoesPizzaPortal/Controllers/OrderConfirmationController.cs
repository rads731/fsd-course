using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JoesPizzaPortal.Controllers
{
    public class OrderConfirmationController : Controller
    {
        // GET: OrderConfirmationController
        public ActionResult Index()
        {
            return View("~/Views/OrderConfirmation/OrderConfirmation.cshtml");
        }

        // GET: OrderConfirmationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderConfirmationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderConfirmationController/Create
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

        // GET: OrderConfirmationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderConfirmationController/Edit/5
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

        // GET: OrderConfirmationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderConfirmationController/Delete/5
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
