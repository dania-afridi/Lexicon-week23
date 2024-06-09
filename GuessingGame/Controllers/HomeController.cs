using GuessingGame.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GuessingGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private const string sessionKey = "RandomNumber";
        private const string sessionCount = "GuessCount";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int? Guess = int.TryParse(Request.Query["userGuess"], out var guessValue)
                ? guessValue
                : (int?)null;

            ViewBag.Message = GuessCheck.Guess(Guess);
            return View(Guess);
            /*if (Session[sessionKey] == null)
             {
                 Session[sessionKey] = GenerateRandomNumber();
                 Session[sessionKey] = 0;
             }*/
        }
        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
