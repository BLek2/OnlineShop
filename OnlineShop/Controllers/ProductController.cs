using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        //Signature for models
        [HttpGet]
        public ActionResult Console()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Console(OnlineShop.Models.Console console)
        {

            return View();
        }
        [HttpGet]
        public ActionResult Laptop()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Laptop(Laptop laptop)
        {
            return View();
        }
        [HttpGet]
        public ActionResult PC()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PC(PC pC)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Smartphone()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Smartphone(Smartphone smartphone)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Tablet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Tablet(Tablet tablet)
        {
            return View();
        }


    }
}