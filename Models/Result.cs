using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobbedUpApp.Models {
    public class Result {
        public int utc_offset { get; set; }
        public Venue venue { get; set; }
        public int headcount { get; set; }
        public double distance { get; set; }
        public string visibility { get; set; }
        public int waitlist_count { get; set; }
        public object created { get; set; }
        public int maybe_rsvp_count { get; set; }
        public string description { get; set; }
        public string event_url { get; set; }
        public int yes_rsvp_count { get; set; }
        public int duration { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public object time { get; set; }
        public object updated { get; set; }
        public Group group { get; set; }
        public string status { get; set; }
        public int? rsvp_limit { get; set; }
        public string how_to_find_us { get; set; }
        public Fee fee { get; set; }

        public override string ToString() {
            return $"{name} at {time}";
        }

    }   //class Result 
}
