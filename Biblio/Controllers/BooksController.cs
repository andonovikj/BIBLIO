using Biblio.Data;
using Biblio.Data.Services;
using Biblio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblio.Controllers
{
    public class BooksController : Controller
    {
        //private readonly AppDbContext _context;

        private readonly IBooksService _service;


        public BooksController(IBooksService service)
        {
            _service = service;
        }


        // GET: BooksController
        public async Task<IActionResult> Index()
        {
            var allBooks = await _service.GetAll();
            return View(allBooks);
        }

        // GET: BooksController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var bookDetails = await _service.GetByIdAsync(id);

            if (bookDetails == null) return View("NotFound");
            return View(bookDetails);
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(IFormCollection formCollection)
        {
            if (ModelState.IsValid)
            {
                Book book = new Book();
                book.Title = formCollection["Title"];
                book.Description = formCollection["Description"];
                book.BookCoverURL = formCollection["BookCoverURL"];
                book.Rating = Convert.ToDouble(formCollection["Rating"]);
                var value = formCollection["genre"];
                book.genre = (Data.Enums.Genre)Convert.ToInt32(value);
                await _service.AddAsync(book);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: BooksController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            var bookDetails = await _service.GetByIdAsync(id);

            if (bookDetails == null) return View("NotFound");
            return View(bookDetails);
        }
    

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, IFormCollection formCollection)
        {
            if (ModelState.IsValid) //checks for validations [Required]
            {
                Book book = await _service.GetByIdAsync(id);

                book.Title = formCollection["Title"];
                book.Description = formCollection["Description"];
                book.BookCoverURL = formCollection["BookCoverURL"];
                book.Rating = Convert.ToDouble(formCollection["Rating"]);
                var value = formCollection["genre"];
                book.genre = (Data.Enums.Genre)Convert.ToInt32(value);

                await _service.UpdateAsync(id, book);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        // GET: BooksController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var bookDetails = await _service.GetByIdAsync(id);

            if (bookDetails == null) return View("NotFound");
            return View(bookDetails);
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id, IFormCollection collection)
        {
            var bookDetails = await _service.GetByIdAsync(id);
            if (bookDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
