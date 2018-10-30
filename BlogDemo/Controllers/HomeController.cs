using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogDemo.Models;

namespace BlogDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        BlogEntities db = new BlogEntities();
        public ActionResult Index()
        {
            ViewBag.tuijian = db.View_Gallery
                .Where(g => g.PosId==1)
                .OrderByDescending(g => g.Weight)
                .Take(10)
                .ToList();
            return View();
        }
    }
}