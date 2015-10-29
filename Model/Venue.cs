using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobbedUpApp.Models {
    public class Venue {
        public string zip { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string address_1 { get; set; }
        public string name { get; set; }
        public double lon { get; set; }
        public int id { get; set; }
        public string state { get; set; }
        public double lat { get; set; }
        public bool repinned { get; set; }
        public string address_2 { get; set; }
        public string phone { get; set; }
    }   //class Venue 
}
