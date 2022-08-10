using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirdXmEve.Models;
namespace ThirdXmEve.Controllers
{
    public class HomeController : Controller
    {
        ThirdXmEveEntities db = new ThirdXmEveEntities();
        public ActionResult Index()
        {
            var pst = db.Posts.ToArray();
            var cat = db.Categories.ToArray();

            ViewBag.posts = pst;
            ViewBag.categories = cat;
            return View();
        }
        public ActionResult PostByCategory(int? id)
        {
            var pst = db.Posts.Where(p => p.CategoryID == id).ToList();
            var cat = db.Categories.ToArray();
            ViewBag.postbyid = pst;
            ViewBag.categories = cat;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}