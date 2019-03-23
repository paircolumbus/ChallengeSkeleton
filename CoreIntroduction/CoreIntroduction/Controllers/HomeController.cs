using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreIntroduction.Models;

namespace CoreIntroduction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //replace with your codez
            throw new NotImplementedException();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            //replace with your codez
            throw new NotImplementedException();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            //replace with your codez
            throw new NotImplementedException();
        }

        public IActionResult Privacy()
        {
            //replace with your codez
            throw new NotImplementedException();
        }

        //Don't worry about this:
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
