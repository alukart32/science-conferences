using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ScienceConferenceApp.Model;

namespace ScienceConferenceApp.DataInitializer
{

    /*
     * Class for comboBox's data initializing 
     * 
     * 
     */
    class CheckBoxDataInit : DataInit
    {
        public CheckBoxDataInit(DbAppContext db) : base(db)
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

        public void addCompanies(ComboBox cb)
        {
            company all = new company();
            all.companyName = "all";
            all.companyId = 0;
            List<company> c = new List<company>();
            c.Add(all);
            c.AddRange(db.companies.ToList());

            cb.DataSource = c;
        }

        public void addThemes(ComboBox cb)
        {
            theme all = new theme();
            all.themeName = "all";
            all.themeId = 0;
            List<theme> cs = new List<theme>();
            cs.Add(all);
            cs.AddRange(db.themes.ToList());

            cb.DataSource = cs;
        }

        public void addSubjects(ComboBox cb)
        {
            subject all = new subject();
            all.subject1 = "all";
            all.subjectId = 0;
            List<subject> cs = new List<subject>();
            cs.Add(all);
            cs.AddRange(db.subjects.ToList());

            cb.DataSource = cs;
        }

        public void addDegrees(ComboBox cb)
        {
            academicDegree all = new academicDegree();
            all.degree = "all";
            all.degreeId = 0;
            List<academicDegree> cs = new List<academicDegree>();
            cs.Add(all);
            cs.AddRange(db.academicDegrees.ToList());

            cb.DataSource = cs;
        }


    }
}
