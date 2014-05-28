using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeDayReports.Model;
using HomeDayReports.Models.Dtos;
using HomeDayReports.Repository;
using Newtonsoft.Json;

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
        public JsonResult AddReport(string dateTimeNow)
        {
            DateTime reportDate = JsonConvert.DeserializeObject<DateTime>(dateTimeNow);

            //List<DayReport> reports = new List<DayReport>();

            using (var db = new DBContext())
            {

                if (dateTimeNow != null)
                {
                    DayReport report = new DayReport()
                    {
                        ReportDate = reportDate
                    };
                    db.DayReports.Add(report);
                    db.SaveChanges();
                }
                //reports = db.DayReports.ToList();
                var reports = db.DayReports
                            .OrderBy(r => r.ReportDate)
                            .Select(r => new DayReportAjaxDto
                                { 
                                    DayReport = r,
                                    BusinesIdeasCount = r.BusinesIdeas.Count,
                                    DoneTasksCount = r.DoneTasks.Count,
                                    EventsCount = r.Events.Count,
                                    ExpensesCount = r.Expenses.Count,
                                    IdeasCount = r.Ideas.Count
                                })
                            .ToList();

                string jsonString = JsonConvert.SerializeObject(reports);
                return Json(jsonString);
            }
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
