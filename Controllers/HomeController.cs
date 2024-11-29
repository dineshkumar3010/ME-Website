using Microsoft.AspNetCore.Mvc;
using PropEquityME.Models;
using System.Diagnostics;

namespace PropEquityME.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Commingsoon()
        {
            return View();
        }
        [Route("home")]
        public IActionResult Home()
        {
            ViewData["bodyClass"] = "home";
            return View();
        }

        [Route("privacy-policy")]
        public IActionResult PrivacyPolicy()
        {
            return View();
        }

        //[Route("comming-soon")]
        //public IActionResult Commingsoon()
        //{
        //    return View();
        //}

        [Route("about-us")]
        public IActionResult AboutUS()
        {
            return View();
        }

        [Route("contact-us")]
        public IActionResult ContactUs()
        { 
            return View();
        }

        [Route("our-history")]
        public IActionResult OurHistory()
        {
            return View();
        }

        [Route("our-team")]
        public IActionResult OURTeam()
        {
            return View();
        }

        [Route("product-and-services")]
        public IActionResult ProductAndServices()
        {
            return View();
        }

        [Route("schedule-a-demo")]
        public IActionResult Schedule_A_Demo()
        {
            return View();
        }
        [Route("terms-and-conditions")]
        public IActionResult terms_n_conditions()
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
