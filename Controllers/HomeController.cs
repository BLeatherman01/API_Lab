using API_LAB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static API_LAB.Models.Data;

namespace API_LAB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        RedditDAL api = new RedditDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
 
            return View();
        }
        
        public IActionResult Post()
        {
          Rootobject rp = api.GetPost();
            
            return View(rp);  
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