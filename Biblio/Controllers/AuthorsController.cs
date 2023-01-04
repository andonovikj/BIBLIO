using Biblio.Data;
using Biblio.Data.Service;
using Biblio.Models;
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
        public async Task<ActionResult> DetailsAsync(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);

            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }


        // GET: AuthorsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection formCollection)
        {
            if (ModelState.IsValid)
            {
                Author author = new Author();
                author.Name = formCollection["Name"];
                author.Bio = formCollection["Bio"];
                author.ProfilePictureURL = formCollection["ProfilePictureURL"];
                var value = formCollection["genre"];
                author.genre = (Data.Enums.Genre)Convert.ToInt32(value);
                await _service.AddAsync(author);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: AuthorsController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);

            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        // POST: AuthorsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, IFormCollection formCollection)
        {
            if (ModelState.IsValid) //checks for validations [Required]
            {
                Author author = await _service.GetByIdAsync(id);

                author.Name = formCollection["Name"];
                author.Bio = formCollection["Bio"];
                author.ProfilePictureURL = formCollection["ProfilePictureURL"];
                var value = formCollection["genre"];
                author.genre = (Data.Enums.Genre)Convert.ToInt32(value);

                await _service.UpdateAsync(id, author);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        // GET: AuthorsController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);

            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        // POST: AuthorsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id, IFormCollection collection)
        {
            var authorDetails = await _service.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
