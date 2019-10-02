using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScienceConferenceApp.Model;

namespace ScienceConferenceApp.DataInitializer
{
  
    /*
     * Class for comboBox's data initializing 
     * 
     * 
     */
    class ConferenceFormDataInit : DataInit
    {
        public ConferenceFormDataInit(DbAppContext db) : base(db)
        {}

        public ComboBox addConferences(ComboBox cb)
        {
            conference all = new conference();
            all.conferenceName = "all";
            all.conferenceId = 0;
            List<conference> confs = new List<conference>();
            confs.Add(all);
            confs.AddRange(db.conferences.ToList());

            cb.DataSource = confs;

            return cb;
        }

        public void addAddresses(ComboBox cb)
        {
            address all = new address();
            all.address1 = "all";
            all.addressId = 0;
            List<address> adds = new List<address>();
            adds.Add(all);
            adds.AddRange(db.addresses.ToList());

            cb.DataSource = adds;

        }

        public void addCountries(ComboBox cb)
        {
            country all = new country();
            all.code = "all";
            all.countryId = 0;
            List<country> cs = new List<country>();
            cs.Add(all);
            cs.AddRange(db.countries.ToList());

            cb.DataSource = cs;
        }
    }
}
