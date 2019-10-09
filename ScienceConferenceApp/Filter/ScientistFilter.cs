using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.Filter
{
    class ScientistFilter
    {
        public ScientistFilter()
        {
            degree = 0;
            country = 0;
            company = 0;
        }

        public int degree { get; set; }
        public int country { get; set;}
        public int company { get; set; }
    }
}
