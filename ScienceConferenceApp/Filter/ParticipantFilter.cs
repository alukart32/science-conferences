using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.Filter
{
    class ParticipantFilter
    {
        public ParticipantFilter()
        {
            conference = 0;
            participant = 0;
            theme = 0;
            subject = 0;
            degree = 0;
        }

        public int conference { get; set; }
        public int participant { get; set; }
        public int theme { get; set; }
        public int subject { get; set; }
        public int degree { get; set; }
    }
}
