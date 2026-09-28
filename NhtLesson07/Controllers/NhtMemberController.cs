using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhtLesson07.Models;

namespace NhtLesson07.Controllers
{
    public class NhtMemberController : Controller
    {
        private static List<NhtMember> nhtmembers = new List<NhtMember>();
        // GET: NhtMemberController
        public ActionResult Index()
        {
            return View(nhtmembers);
        }

        // GET: NhtMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NhtMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhtMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NhtMember nhtmember)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(nhtmember);
                }
                nhtmembers.Add(nhtmember);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NhtMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NhtMemberController/Edit/5
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

        // GET: NhtMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NhtMemberController/Delete/5
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
