using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SINGLETON.Configuration;
using SINGLETON.Models;
using System.Diagnostics;
using Utilities;

namespace SINGLETON.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<Config> _config;

        public HomeController(IOptions<Config> config)
        {
            _config = config ;
        }

        public IActionResult Index()
        {
            Log.GetInstance(_config.Value.Path).Save("Se inició la vista Index");
            return View();
        }

        public IActionResult Privacy()
        {
            Log.GetInstance(_config.Value.Path).Save("Se inició la vista Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}