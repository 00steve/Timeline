using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimelineApp.Models.Database;
using TimelineApp.Models.UserInterface;

namespace TimelineApp.Services
{
    public class DatabaseService
    {
        static public Timeline GetTimeline(int id)
        {
            Database db = new Database();
            Timeline tl = db.Timelines.Where(x => x.ID == id).FirstOrDefault();
            if(tl == null)
            {
                tl = new Timeline();
                tl.ID = -1;
            }
            return tl;
        }

        static public TimelineIndex GetTimelineIndex(int userId)
        {
            Database db = new Database();
            TimelineIndex ti = new TimelineIndex();
            ti.Timelines = db.Timelines.Where(x => x.UserID == userId).ToList();

            return ti;
        }
    }
}