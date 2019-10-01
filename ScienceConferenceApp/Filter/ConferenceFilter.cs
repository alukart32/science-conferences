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
            conference = 1;
            subject = 1;
            theme = 1;
        }

        public int conference { get; set; }
        public int subject { get; set; }
        public string theme { get; set; }
    }
}
