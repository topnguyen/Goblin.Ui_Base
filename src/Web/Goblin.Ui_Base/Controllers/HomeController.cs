using Microsoft.AspNetCore.Mvc;

namespace Goblin.Ui_Base.Controllers
{
    public class HomeController : BaseController
    {
        [Route("~/")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("~/about-us")]
        [HttpGet]
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}