using MyPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class TestimonialController : Controller
    {
        DbMyPortfolioEntities context= new DbMyPortfolioEntities();

        public ActionResult Index()
        {
            
            return View();
        }
    }
}