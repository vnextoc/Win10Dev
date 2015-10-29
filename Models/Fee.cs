using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobbedUpApp.Models {
    public class Fee {
        public int amount { get; set; }
        public string accepts { get; set; }
        public string description { get; set; }
        public string currency { get; set; }
        public string label { get; set; }
        public string required { get; set; }
    }   //class Fee 
}
