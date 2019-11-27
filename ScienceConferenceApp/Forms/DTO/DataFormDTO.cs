using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.Forms.DTO
{
    public class DataFormDTO
    {
        public BaseForm caller { get; set; }
        public BaseForm mainForm { get; set; }
        public DbAppContext db { get; set; }

        public UserDataDTO userData { get; set; }

        public DataFormDTO(BaseForm caller, BaseForm mainForm, DbAppContext db, UserDataDTO userData)
        {
            this.caller = caller;
            this.mainForm = mainForm;
            this.db = db;
            this.userData = userData;
        }

        public DataFormDTO()
        {
        }
    }
}
