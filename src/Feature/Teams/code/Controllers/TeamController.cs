using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hackathon.Feature.Teams.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult TeamListing()
        {
            Sitecore.Context.Database.GetItem("").Fields["Team Name"].Value
            return View();
        }
    }
}