using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobSovAlytalo.Controllers
{
    public class NewsiteController : Controller
    {
        // GET: Newsite
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateAccount()
        {
            return View();
        }

        public ActionResult Something()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}