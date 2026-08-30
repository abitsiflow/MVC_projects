using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace mimoMVC.Controllers
{
    public class myController : Controller
    {
        public ActionResult myView()
        {
            ViewBag.Message = "This is my view page, What's up? :)";
            return View();
        }
    }
}