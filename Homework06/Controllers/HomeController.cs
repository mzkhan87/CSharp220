using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework06.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RsvpForm(Models.SendCard sendCard)
        {
            if(!ModelState.IsValid)
            {
                return View("MissingFields", sendCard);
            }
            else
            {
                return View("AllValidFields",sendCard);
            }
            
        }

    }
}