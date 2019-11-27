using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.DTO
{
    public class CompanyDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int country { get; internal set; }
    }
}
