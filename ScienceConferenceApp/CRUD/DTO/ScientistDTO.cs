using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.DTO
{
    class ScientistDTO
    {
        public int degree { get; set; }
        public int country { get; set; }
        public int company { get; set; }

        public string firstName { get; set; }
        public string secondName { get; set; }
    }
}
