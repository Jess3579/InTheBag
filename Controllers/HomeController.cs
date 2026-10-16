using InTheBag.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InTheBag.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexViewBag()
        {
            IList<string> wishList = new List<string>();
            wishList.Add("Peace");
            wishList.Add("Health");
            wishList.Add("Happiness");

            ViewBag.WishList = wishList;

            return View();
        }

        public IActionResult IndexViewData()
        {
            IList<string> wishList = new List<string>();
            wishList.Add("Quies");
            wishList.Add("Saltern");
            wishList.Add("Beatitudinem");

            ViewData["WishList"] = wishList;

            return View();
        }

        public IActionResult IndexTempData()
        {
            IList<string> wishList = new List<string>();
            wishList.Add("La Paz");
            wishList.Add("La Salud");
            wishList.Add("La Felicidad");

            TempData["WishList"] = wishList;

            return View();
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