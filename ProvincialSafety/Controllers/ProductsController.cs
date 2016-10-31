using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvincialSafety.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult HeadProtection()
        {
            return View();
        }

        public ActionResult Clothing()
        {
            return View();
        }

        public ActionResult HandProtection()
        {
            return View();
        }
    }
}