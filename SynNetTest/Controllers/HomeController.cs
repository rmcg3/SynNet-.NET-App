using Syn.WordNet;
using System.IO;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SynNetTest.Models;

namespace SynNetTest.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var home = new HomeModel()
            {
                directory = Directory.GetCurrentDirectory(),
                wordNet = new WordNetEngine(),
            };
            return View(home);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
