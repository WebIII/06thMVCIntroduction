using Microsoft.AspNetCore.Mvc;
using SnakeEyesGame.Models;

namespace SnakeEyesGame.Controllers
{
    public class HomeController : Controller
    {
        private SnakeEyes _snakeEyes;
        public IActionResult Index()
        {
            _snakeEyes = new SnakeEyes();
            return View(_snakeEyes);
        }
    }
}