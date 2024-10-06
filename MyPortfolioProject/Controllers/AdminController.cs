using MyPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class AdminController : Controller
    {
        DbMyPortfolioEntities context=new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar() 
        {
            var ımg=context.Profile.Select(x => x.ImageUrl).FirstOrDefault();

            ViewBag.img = ımg;
            return PartialView();
        }
        public PartialViewResult PartialNavbar() 
        { 
        return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}