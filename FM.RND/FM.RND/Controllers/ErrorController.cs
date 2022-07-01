using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FM.RND.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Error404()
        {
            return View();
        }

        public ActionResult Error500()
        {
            return View();
        }
    }
}
