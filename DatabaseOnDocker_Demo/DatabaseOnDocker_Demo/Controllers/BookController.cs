using DatabaseOnDocker_Demo.Data;
using DatabaseOnDocker_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DatabaseOnDocker_Demo.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext Context;

        public BookController(ApplicationDbContext context)
        {
            this.Context = context;
        }

        public IActionResult Index()
        {
            var books = Context.Books.ToList();
            return View(books);
        }

        [HttpPost]
        public IActionResult Create()
        {
            var books = Context.Books.ToList();
            return View(books);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Context.Books.Add(book);
                    await Context.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty, $"Something went wrong, {ex.Message}");
                }
            }

            ModelState.AddModelError(string.Empty, $"Something went wrong");
            return View(book);
        }

    }
}