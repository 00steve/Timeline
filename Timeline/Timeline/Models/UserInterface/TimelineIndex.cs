using System.Collections.Generic;
using TimelineApp.Models.Database;

namespace TimelineApp.Models.UserInterface
{
    public class TimelineIndex
    {

        public TimelineIndex()
        {
            Timelines = new List<Timeline>();
        }
        public List<Timeline> Timelines { get; set; }
    }
}