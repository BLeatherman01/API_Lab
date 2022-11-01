using API_LAB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


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
            Rootobject r = api.GetPost();
            //this act as a file path, if I start digging here I have immediate access to all the post data
            //This will simplify calling it in my view
            Data1 d = r.data.children[1].data;
            return View(d);
        }
        
        public IActionResult Post()
        {
            Rootobject r = api.GetPost();
            Child[] post = r.data.children;
            
            return View(post);  
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