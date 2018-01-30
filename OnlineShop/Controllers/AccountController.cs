using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models.TemporaryModels;
using OnlineShop.Models.TemplateModels;
using OnlineShop.Models;
using System.Text.RegularExpressions;
using OnlineShop.Models.AnotherModels;

namespace OnlineShop.Controllers
{
    public class AccountController : Controller
    {
        OnlineShopContext DbOnlineShop = new OnlineShopContext();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register register)
        {
            IEnumerable<SecreatCombinations> secreatCombination = DbOnlineShop.SecreatCombinations;


            //Name Validation

            if (string.IsNullOrEmpty(register.Name))
            {
                 ModelState.AddModelError("Name", "The field is required");
            }
            else if(register.Name.Length < 3 || register.Name.Length > 50)
            {
                ModelState.AddModelError("Name", "The Name must be between 50 and 3 symbols");
            }

            //Email Validation
            if (string.IsNullOrEmpty(register.Email))
            {
                ModelState.AddModelError("Email", "The field is required");
            }
            else if(Regex.IsMatch(register.Email, @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}") == false)
            {
                ModelState.AddModelError("Email", "Not correct email");
            }

            //Password Validation
            if (string.IsNullOrEmpty(register.Password))
            {
                ModelState.AddModelError("Password", "The field is required");
            }
            else if (register.Password.Length < 4)
            {
                ModelState.AddModelError("Password", "Min value is 4");
            }
            else if(register.Password.Length > 50)
            {
                ModelState.AddModelError("Password", "Max value is 50");
            }

            //RepeatPassword Validation

            if (string.IsNullOrEmpty(register.RepeatPassword))
            {
                ModelState.AddModelError("RepeatPassword", "The field is required");
            }
            else if(register.RepeatPassword.Length < 4)
            {
                ModelState.AddModelError("RepeatPassword", "Min value is 4");
            }
            else if(register.RepeatPassword.Length > 50)
            {
                ModelState.AddModelError("RepeatPassword", "Max value is 50");
            }
            else if(register.Password == register.RepeatPassword)
            {
                ModelState.AddModelError("Password", "Passwords are not equal");
                ModelState.AddModelError("RepeatPassword", "Passwords are not equal");
            }

            //SecreatCombination Validation
            bool IsRight = IssecreatCombinationRight(register);

            if (string.IsNullOrEmpty(register.SecreatCombination))
            {
                ModelState.AddModelError("SecreatCombination", "The field is required");
            }
            else if(register.SecreatCombination.Length < 3 || register.SecreatCombination.Length > 20)
            {
                ModelState.AddModelError("SecreatCombination", "The secreat combination must be between 3 and 20 symbols");
            }
            else if(IsRight == false)
            {
                ModelState.AddModelError("SecreatCombination", "The secreat combination is not right");
            }



            if (ModelState.IsValid)
            {
                Manager manager = new Manager
                {
                    Name = register.Name,
                    Email = register.Email,
                    Password = register.Password,
                    DatimeRegister = System.DateTime.Now
                };
                DbOnlineShop.Managers.Add(manager);
                DbOnlineShop.SaveChanges();
            }

          
            return View();
        }

        public bool IssecreatCombinationRight(Register register)
        {
            IEnumerable<SecreatCombinations> secreatCombination = DbOnlineShop.SecreatCombinations;

            foreach (var b in secreatCombination)
            {
                if (register.SecreatCombination == b.SecreatCombination)
                {
                    return true;
                }
            }
            return false;
        }
    }
}