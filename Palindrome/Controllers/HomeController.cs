using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Polindrome.Models;
using Polindrome.Services;

namespace Polindrome.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPalindrome _palindrome;
        public HomeController(IPalindrome palindrome)
        {
            _palindrome = palindrome;
        }

        public IActionResult Index()
        {
            var model = new IndexModel
            {
                Word = "",
                IsPalindrome = false
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index([FromForm] IndexModel model)
        {
            var palindrome = _palindrome.IsPalindrome(model.Word);

            var data = new IndexModel
            {
                Word = model.Word,
                IsPalindrome = palindrome
            };

            return View(data);
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
