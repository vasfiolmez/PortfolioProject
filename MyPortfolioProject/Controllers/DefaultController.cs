﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead() 
        {
        return PartialView();
        }
        public PartialViewResult PartialScript() 
        {
        return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
    }
}