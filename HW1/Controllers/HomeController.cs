using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW1.Models;

namespace HW1.Controllers
{
    public class HomeController : Controller
    {
        public class HomeViewModel
        {
            public int PhoneCount;
            public int UserCount;
            public DateTime LastAcessDate;
        }

        return View();
    }



        public ActionResult FAQ()
        {
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