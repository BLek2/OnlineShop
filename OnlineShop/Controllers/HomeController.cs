using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {

        OnlineShopContext onlineDb = new OnlineShopContext();
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Laptops()
        {
            IEnumerable<Laptop> laptops = onlineDb.Laptops;

            ViewBag.laptops = laptops;
            return View();
        }
        public ActionResult PC()
        {
            return View();
        }
        public ActionResult Smartphones()
        {
            return View();
        }
        public ActionResult Tablets()
        {
            return View();
        }
        public ActionResult Consoles()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Laptop(int? Id)
        {
            var FindLaptop = onlineDb.Laptops.First(p => p.Id == Id);

            ViewBag.foundlaptop = FindLaptop;

            return View();
        }
      

    }
}