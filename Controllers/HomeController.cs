using csharp_boolflix.Database;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace csharp_boolflix.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
        private readonly BoolflixContext _context;

        public HomeController(BoolflixContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ContenutoVideo> videoContenutiList = _context.ContenutiVideo.ToList();

            Random rnd = new Random();
            ContenutoVideo videoContent = videoContenutiList[rnd.Next(0, videoContenutiList.Count())];

            ViewData["Jumbotron"] = videoContent;
            return View("Index", videoContenutiList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}