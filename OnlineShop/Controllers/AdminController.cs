using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models.AnotherModels;
using System.Text.RegularExpressions;

namespace OnlineShop.Controllers
{
    public class AdminController : Controller
    {

        OnlineShopContext DbOnlineShop = new OnlineShopContext();

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
        
        public ActionResult AddProduct()
        {
            return View();
        }
        public ActionResult EditProduct()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ChangeSecreatCombination()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangeSecreatCombination(SecreatCombinations secreatcombination)
        {
         
                var phones = DbOnlineShop.Database.ExecuteSqlCommand("EXECUTE DeleteValueFromSecreatCombination");

                DbOnlineShop.SecreatCombinations.Add(secreatcombination);
                DbOnlineShop.SaveChanges();
              
            return View();
        }
        public ActionResult ShowApplies()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddManager()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddManager(Manager manager)
        {
            //~~~~~~~~~Server validation~~~~~~~~~

            //Name Validation
            if (string.IsNullOrEmpty(manager.Name))
            {
                ModelState.AddModelError("Name", "The field is required");

            }

            else if (manager.Name.Length < 3 || manager.Name.Length > 50)
            {
                ModelState.AddModelError("Name", "The Name must be between 50 and 3 symbols");
            }

            //Email Validation
            if (string.IsNullOrEmpty(manager.Email))
            {
                ModelState.AddModelError("Email", "The field is required");
            }
            else if (Regex.IsMatch(manager.Email, @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}") == false)
            {
                ModelState.AddModelError("Email", "Not correct email");
            }

            //Password Validation
            if (string.IsNullOrEmpty(manager.Password))
            {
                ModelState.AddModelError("Password", "The field is required");
            }
            else if (manager.Password.Length < 4 == true)
            {
                ModelState.AddModelError("Password", "Min value is 4");
            }
            else if (manager.Password.Length > 50 == true)
            {
                ModelState.AddModelError("Password", "Max value is 50");
            }
            if (ModelState.IsValid)
            {
                manager.DatimeRegister = DateTime.Now;
                DbOnlineShop.Managers.Add(manager);
                DbOnlineShop.SaveChanges();

            }

            return View(manager);
        }
        public ActionResult ShowStatistic()
        {
            return View();
        }
        public ActionResult InstractionAboutUsingSystem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignOff()
        {

            Session["Manager"] = null;
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