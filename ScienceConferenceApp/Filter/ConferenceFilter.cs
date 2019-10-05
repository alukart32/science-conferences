using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.Filter
{
    class ConferenceFilter
    {
        public ConferenceFilter()
        {
            conference = 0;
            address = 0;
            country = 0;
            date = DateTime.MinValue;
            withDate = false;
        }

        public int conference { get; set; }
        public int address { get; set; }
        public int country { get; set; }
        public DateTime date { get; set; }
        public bool withDate { get; set; }
    }
}
