using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;
using System.IO;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        OnlineShopContext DbOnlineShop = new OnlineShopContext();
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
        public ActionResult Laptop(Laptop laptop, HttpPostedFileBase mainimage)
        {
            //Title Validation
            if (String.IsNullOrEmpty(laptop.Title))
            {
                ModelState.AddModelError("Title", "The field is required");
            }
            if (laptop.Title.Length < 3 || laptop.Title.Length > 250)
            {
                ModelState.AddModelError("Title", "The field is required");
            }

            //CodeOfProduct Validation

            if(laptop.CodeOfProduct == null)
            {
                ModelState.AddModelError("CodeOfProduct", "The field is required");
            }


            //Warrantly Validation

            if(laptop.Warrantly == null)
            {
                ModelState.AddModelError("Warrantly", "The field is required");
            }



            //Price Validation

            if (laptop.Price == null)
            {
                ModelState.AddModelError("Price", "The field is required");
            }
            if(laptop.Price < 1 || laptop.Price > 999999)
            {
                ModelState.AddModelError("Price", "Ivalid field");
            }

            //Count Validation
            if(laptop.Count == null)
            {
                ModelState.AddModelError("Count", "The field is required");
            }
            if(laptop.Count < 1 || laptop.Count > 10000)
            {
                ModelState.AddModelError("Count", "The field is required");
            }

            //Description Validation
            if (String.IsNullOrEmpty(laptop.Description))
            {
                ModelState.AddModelError("Description", "The field is required");
            }

            //MainImagePath Validation
            try
            {
               string checkval=System.IO.Path.GetFileName(mainimage.FileName);

            } catch (Exception)
            {
                ModelState.AddModelError("MainImagePath", "Put file ");
            }
            //AnotherImagesPath Validation


            //Adding images in database 

                string FolderName = GenerateFolderName("");

                Directory.CreateDirectory(Server.MapPath("~/Content/Images/Laptop/" + FolderName));
            
                string MainImageName= System.IO.Path.GetFileName(mainimage.FileName);
                string MainImageUrlPath = "~/Content/Images/Laptop/" + FolderName+ "/" +"MainImage/"+ MainImageName;
                mainimage.SaveAs(Server.MapPath("~/Content/Images/Laptop/" + FolderName +"/"+ MainImageName));


                laptop.MainImagePath = MainImageUrlPath;

                DbOnlineShop.Laptops.Add(laptop);
                DbOnlineShop.SaveChanges();
            
            return View(laptop);
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


        public string GenerateFolderName(string str)
        {
            str = "";
            string variants = "qwertyuiopasdf12345ghjlkz678xcvb90nm";

            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                
                int randomIndex = random.Next(0, 35);
                str += variants[randomIndex];
              
            }
            return str;
        }

    }
}