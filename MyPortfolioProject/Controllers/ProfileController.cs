using MyPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();

        public ActionResult Index()
        {
            var values = context.Profile.FirstOrDefault();

            return View(values);
        }

        [HttpPost]
        public ActionResult Index(Profile profile)
        {
            var value = context.Profile.Find(profile.ProfileId);

            value.Birthdate = profile.Birthdate;
            value.Email = profile.Email;
            value.Phone = profile.Phone;
            value.Githup = profile.Githup;
            value.Adress = profile.Adress;
            value.Title = profile.Title;
            value.ImageUrl = profile.ImageUrl;
            value.Description = profile.Description;

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}