using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u24758354_Practical.Models;

namespace u24758354_Practical.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult JournalistPublication()
        {
            var publication = Repository.GetPublications();
            return View(publication);
        }
    }
}