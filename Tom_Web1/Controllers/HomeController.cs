using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tom_Web1.Models;
using Tom_Web1.Repository;

namespace Tom_Web1.Controllers
{
    public class HomeController : Controller
    {
        DataRepository repo;
        public HomeController(DataRepository _repo)
        {
            repo = _repo;

        }

      
        public IActionResult Index(int? Id)
        {
            if (Id == null)
                Id = 1;

            var data = repo.GetGebruikersPerProject((int)Id);
            return View(data);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
