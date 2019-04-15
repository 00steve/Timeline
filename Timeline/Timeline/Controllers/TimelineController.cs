using System.Web.Mvc;
using TimelineApp.Models.Database;
using TimelineApp.Models.UserInterface;
using TimelineApp.Services;

namespace TimelineApp.Controllers
{
    public class TimelineController : Controller
    {
        // GET: Timeline
        public ActionResult Index()
        {
            TimelineIndex tli = DatabaseService.GetTimelineIndex(1);
            return View("TimelineIndex",tli);
        }


        public ActionResult Timeline(int id)
        {
            Timeline ti = DatabaseService.GetTimeline(id);
            return View(ti);
        }
    }
}