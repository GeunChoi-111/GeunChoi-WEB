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

        public ActionResult Error400()
        {
            Response.StatusCode = 400;
            return View();
        }

        public ActionResult Error401()
        {
            Response.StatusCode = 401;
            return View();
        }

        public ActionResult Error403()
        {
            Response.StatusCode = 403;
            return View();
        }

        public ActionResult Error404()
        {
            Response.StatusCode = 404;
            return View();
        }

        public ActionResult Error500()
        {
            Response.StatusCode = 500;

            //View Return 방식
            //return View();
            //return Vie w("../Error/Error500");
            //return View("./Error500");
            //return View("/Views/Error/Error500.cshtml");
            return View();
        }
    }
}
