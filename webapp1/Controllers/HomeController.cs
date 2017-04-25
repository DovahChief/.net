using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Pagina de contacto";
            var x = new Models.ApplicationUser();
            ViewData["Title"] = x.Fun();

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
