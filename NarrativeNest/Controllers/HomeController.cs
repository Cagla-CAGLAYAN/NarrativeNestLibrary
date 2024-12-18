using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NarrativeNest.Data;
using NarrativeNest.Models;
using NarrativeNest.Models.Entities;
using System.Diagnostics;

namespace NarrativeNest.Controllers
{
    public class HomeController : Controller
    { private readonly ApplicationDbContext _context;
    
       /* private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetBook(int bookId)
        {
            var bookIdGuid = new Guid(bookId.ToString());
            var bookById = _context.Books.FirstOrDefault(b => b.BookId == bookIdGuid);

            if (bookById == null)
            {
                return NotFound("Kitap ID'sine sahip bir kitap bulunamadý.");
            }

            return Ok(bookById);
        }
        public IActionResult AddBook()
        {
            var newBook = new Books
            {
                Title = "Kitap Adý Örneði",
                Author = "Yazar Adý Örneði",
                Genre = "History",
                BookStatus = "Free",
                PageNumber = 250

            };

            _context.Books.Add(newBook);
            _context.SaveChanges();
            return Ok("Kitap Eklendi");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
