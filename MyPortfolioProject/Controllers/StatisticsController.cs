using MyPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class StatisticsController : Controller
    {
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.totalMessageCount = context.Contact.Count();
            ViewBag.messageIsReadTrueCount = context.Contact.Where(x => x.IsRead == true).Count();
            ViewBag.messageIsReadFalseCount = context.Contact.Where(x => x.IsRead == false).Count();
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.skillRateSum = context.Skills.Sum(x => x.Rate);
            ViewBag.skillRateAvg = context.Skills.Average(x => x.Rate);

            var maxRate = context.Skills.Max(x => x.Rate);
            ViewBag.maxRateSkillName = context.Skills.Where(x => x.Rate == maxRate).Select(y => y.SkillName).FirstOrDefault();

            ViewBag.getMessageCountBtSubjectReferances=context.Contact.Where(x=>x.Subject=="Referans").Count();

            ViewBag.getMessafeCountByEmailContainHAndIsReadTrue=context.Contact.Where(x=>x.IsRead==true && x.Email.Contains("h")).Count();

            return View();
        }
    }
}