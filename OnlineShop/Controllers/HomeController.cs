using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Laptops()
        {
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

    }
}