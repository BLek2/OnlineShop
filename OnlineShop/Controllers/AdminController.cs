using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class AdminController : Controller
    {
      
        public ActionResult Room()
        {
            bool CheckAuth = IsAuthenticated();
            if(CheckAuth == true)
            {
                var manager = Session["Manager"].ToString();
                ViewBag.manager = manager;


                return View();
            }
            return RedirectToAction("Login", "Account");     
        }
        public bool IsAuthenticated()
        {
            if(Session["Manager"] == null)
            {
                return false;
            }

            return true;
        }



    }
}