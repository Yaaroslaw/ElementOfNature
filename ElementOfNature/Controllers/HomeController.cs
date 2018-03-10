using ElementOfNature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElementOfNature.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            Element newFlower = new Element
            {
                Name = "тигр",
                Type = "кулон",
                Id = 0,
                IsPresent = true,
                IsRealToMake = true,
                Price = 100,
                Review = "Найкращий кулон, який я тільки купляла",
                Description = "Чудовий кулон з тиговими квітами"
            };
            return View(newFlower);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}