using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        ForoshContext db = new ForoshContext();
        public ActionResult Index()
        {

            db.TbGroups.Add(new TbGroup() { ID = 1, Title = "کالاهای", Des = "", Parent_id = 1 });
            db.TbGroups.Add(new TbGroup() { ID = 2, Title = "دیجیتال", Des = "", Parent_id = 1 });

            db.TbGroups.Add(new TbGroup() { ID = 3, Title = "پوشاک", Des = "", Parent_id = 1 });

            db.TbGroups.Add(new TbGroup() { ID = 4, Title = "لبتاب", Des = "", Parent_id = 2 });
            db.SaveChanges();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}