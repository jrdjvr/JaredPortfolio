using System.Diagnostics;
using JaredPortfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace SimplePortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }
    }
}
