using MyPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class InternController : Controller
    {
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult InternList()
        {
            var value = context.Intern.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult CreateIntern()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateIntern(Intern education)
        {
            context.Intern.Add(education);
            context.SaveChanges();
            return RedirectToAction("InternList");

        }
        [HttpGet]
        public ActionResult UpdateIntern(int id)
        {
            var value = context.Intern.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateIntern(Intern education)
        {
            var value = context.Intern.Find(education.InternId);
            value.Title = education.Title;
            value.SubTitle = education.SubTitle;
            value.Description = education.Description;
            value.Date = education.Date;
            context.SaveChanges();
            return RedirectToAction("InternList");
        }
        public ActionResult DeleteIntern(int id)
        {
            var value = context.Intern.Find(id);
            context.Intern.Remove(value);
            context.SaveChanges();
            return RedirectToAction("InternList");
        }
    }
}