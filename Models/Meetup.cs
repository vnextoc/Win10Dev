using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobbedUpApp.Models {
    public class Meetup {
        public IList<Result> results { get; set; }
        public Meta meta { get; set; }
    } //class Meetup
}
