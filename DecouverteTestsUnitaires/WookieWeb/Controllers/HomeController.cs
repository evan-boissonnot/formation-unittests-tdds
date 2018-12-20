using StarWarsLibrairie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WookieWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Wookie wookie = new Wookie()
            {
                Name = "dirtolip"
            };

           
            this.ViewBag.MessageWookie = wookie.Crier((mess =>
            {
                this.ViewBag.MessageWookie = mess;
            }); 

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}