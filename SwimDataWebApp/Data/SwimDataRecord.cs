using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwimDataWebApp.Data
{
    public class SwimDataRecord
    {
        public string Course { get; set; }
        public string Gender { get; set; }
        public string AgeGroup { get; set; }
        public string Event { get; set; }

        public string B { get; set; }
        public string BB { get; set; }
        public string A { get; set; }
        public string AA { get; set; }
        public string AAA { get; set; }
        public string AAAA { get; set; }

    }
}

//{
//    "Course": "Long Course Meters",
//    "Gender": "Girls",
//    "AgeGroup": "10 & Under",
//    "Event": "50 M Free",
//    "B": 44.09,
//    "BB": 39.89,
//    "A": 35.59,
//    "AA": 34.19,
//    "AAA": 32.79,
//    "AAAA": 31.39
//  },