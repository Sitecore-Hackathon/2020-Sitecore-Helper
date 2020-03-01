using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hackathon.Feature.Banner.Controllers
{
    public class BannerController : Controller
    {
        public ActionResult Banner()
        {
            return View();
        }
    }
}