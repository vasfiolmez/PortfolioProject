using MyPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class PortfolioController : Controller
    {
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var value=context.Portfolio.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult PortfolioCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PortfolioCreate(Portfolio portfolio)
        {
            context.Portfolio.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PortfolioDelete(int id)
        {
            var value=context.Portfolio.Find(id);
            context.Portfolio.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult PortfolioUpdate(int id)
        {
            var value=context.Portfolio.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult PortfolioUpdate(Portfolio portfolio)
        {

            var value = context.Portfolio.Find(portfolio.PortfolioId);
            value.Title = portfolio.Title;
            value.Description = portfolio.Description;
            value.Image = portfolio.Image;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}