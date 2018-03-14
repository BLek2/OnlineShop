using OnlineShop.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class CustomerController : Controller
    {
       
        OnlineShopContext onlineDb = new OnlineShopContext();

        public ActionResult Cart()
        {
           if(Request.Cookies["Laptop"] != null )
             {
                int IdVal = Int32.Parse(Request.Cookies["Laptop"].Value);
                var FoundedModel = onlineDb.Laptops.Find(IdVal);
                ViewBag.LaptopModel = FoundedModel;
             }

            return View();
        }

        [HttpPost]
        public void AddLaptopToCart(int Id)
        {

            HttpCookie cookie = new HttpCookie("Laptop", Id.ToString());
            Response.Cookies.Add(cookie);
        }
      
    }
}