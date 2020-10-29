using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeligroSport.Core.Entities;
using PeligroSport.Models;

namespace PeligroSport.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<Usuarios> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<Usuarios> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Usuarios user = _userManager.FindByIdAsync(userId).Result;


            if (user == null)
            {
                return RedirectToAction("Login", "Account", new { Area = "Identity" });

            }

            return View();

       
        }

        public IActionResult StartPage()
        {
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
