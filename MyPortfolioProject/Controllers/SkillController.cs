using MyPortfolioProject.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class SkillController : Controller
    {
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult SkillList(int page=1)
        {
            var values = context.Skills.ToList().ToPagedList(page,5);
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkill(Skills skills)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateSkill");
            }
             context.Skills.Add(skills);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        public ActionResult DeleteSkill(int id) 
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id) 
        {
           var value=context.Skills.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Skills skills)
        {
            var value = context.Skills.Find(skills.SkillId);
            value.SkillName = skills.SkillName;
            value.Status=skills.Status;
            value.Rate = skills.Rate;
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}