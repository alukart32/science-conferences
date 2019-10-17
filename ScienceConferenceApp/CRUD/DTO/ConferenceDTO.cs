using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.Model.DTO
{
    class ConferenceDTO
    {
        public ConferenceDTO()
        {
            name = "";
            address = 0;
            country = 0;
            date = DateTime.MinValue;
        }

        public string name { get; set; }
        public int address { get; set; }
        public int country { get; set; }
        public DateTime date { get; set; }
    }
}
