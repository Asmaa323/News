using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using News.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace News.Controllers
{
   
    public class HomeController : Controller
    {
        NewsContext db;
        public HomeController(NewsContext context)
        {
            db = context;
        }


        public IActionResult Index()
        {
          var result= db.Categories.ToList();
            return View(result);
        }

        public IActionResult Viewuser()
        {
            var result = db.ContactUs.ToList();
            return View(result);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult SaveContact(ContactUs model)
        {
            db.ContactUs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult News(int Id)
        {
            Category c = db.Categories.Find(Id);
            ViewBag.Cat = c.Name;
           
            var result = db.News.Where(x => x.CatogryId == Id).ToList();
            return View(result);
    }
        public IActionResult Teammember()
        {
            var result = db.Teammembers.ToList();

            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
