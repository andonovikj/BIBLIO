using Biblio.Data;
using Biblio.Data.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblio.Controllers
{
    public class AuthorsController : Controller
    {
        //private readonly AppDbContext _context;
        private readonly IAuthorsService _service;

        public AuthorsController(IAuthorsService service)
        {
            _service = service;
        }

        // GET: AuthorsController
        public async Task<IActionResult> Index()
        {
            var allAuthors = await _service.GetAll();
            return View(allAuthors);
        }
        
        // GET: AuthorsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: AuthorsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorsController/Create
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

        // GET: AuthorsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuthorsController/Edit/5
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

        // GET: AuthorsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuthorsController/Delete/5
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
