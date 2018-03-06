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
        CookieContainer cookies = new CookieContainer();
        OnlineShopContext onlineDb = new OnlineShopContext();

        public ActionResult Cart()
        {/*
            if (Request.Cookies["Product"] != null)
            {
                int cookieVal = Int32.Parse(Request.Cookies["Product"].Value);
               
                var FindLaptop = onlineDb.Laptops.Find(cookieVal);

                ViewBag.LaptopModel = FindLaptop;
            }
          */
            Hashtable table = (Hashtable)cookies.GetType().InvokeMember("m_domainTable",
                                                                         BindingFlags.NonPublic |
                                                                         BindingFlags.GetField |
                                                                         BindingFlags.Instance,
                                                                         null,
                                                                         cookies,
                                                                         new object[] { });

            foreach (var key in table.Keys)
            {
                foreach (Cookie cookie in cookies.GetCookies(new Uri(string.Format("http://{0}/", key))))
                {
                    return Json(cookie.Name, JsonRequestBehavior.AllowGet);
                }
            }

            return View();
        }

        [HttpPost]
        public void AddLaptopToCart(int? Id)
        {
            cookies.Add(new Cookie( "Product", Id.ToString(), "/", "localhost:55295"));
            
        }
       

    }
}