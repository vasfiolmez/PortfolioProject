using MyPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class DashBoardController : Controller
    {
        DbMyPortfolioEntities context= new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var skills = context.Skills.ToList();

            var skillNames = skills.Select(x => x.SkillName).ToList();
            var skillRates = skills.Select(x => x.Rate).ToList();

            ViewBag.skillName = skillNames;
            ViewBag.skillRate = skillRates;

            return View();
        }
    }
}