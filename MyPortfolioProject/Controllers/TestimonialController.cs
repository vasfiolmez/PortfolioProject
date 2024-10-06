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
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult TestimonialList()
        {
            var values = context.Testimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult TestimonialCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TestimonialCreate(Testimonial testimonial)
        {
            context.Testimonial.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public ActionResult TestimonialDelete(int id)
        {
            var value = context.Testimonial.Find(id);
            context.Testimonial.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }


        [HttpGet]
        public ActionResult TestimonialUpdate(int id)
        {
            var values = context.Testimonial.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult TestimonialUpdate(Testimonial testimonial)
        {
            var values = context.Testimonial.Find(testimonial.TestimonialID);
            values.NameSurname = testimonial.NameSurname;
            values.Title = testimonial.Title;
            values.Description = testimonial.Description;
            values.Image = testimonial.Image;
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}