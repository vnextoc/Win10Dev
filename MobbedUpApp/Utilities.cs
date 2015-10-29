using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobbedUpApp {
    public static class Utilities {
        public static DateTime JavascriptDate(this double milliseconds) {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                .AddMilliseconds(milliseconds);
        }
    }
}
