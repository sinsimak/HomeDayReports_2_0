using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeDayReports.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = DateTime.Now.ToShortDateString();

            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult AddReport(string dateNow)
        {
            DateTime date = DateTime.Parse(dateNow);
            return null;
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
