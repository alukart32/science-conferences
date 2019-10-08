using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.DTO
{
    class ParticipantDTO
    {
        public int conference { get; set; }
        public int participant { get; set; }
        public int theme { get; set; }
        public int subject { get; set; }
        public int degree { get; set; }
    }
}
