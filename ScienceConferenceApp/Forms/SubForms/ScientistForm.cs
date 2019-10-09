using ScienceConferenceApp.Controllers;
using ScienceConferenceApp.CRUD.Model;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceConferenceApp.Forms.SubForms
{
    public partial class ScientistForm : BaseForm
    {
        BaseForm caller;
        DbAppContext db;

        private ScientistController scientistController;
        private ScientistCrud crud;
        ScientistFilter filter;

        public ScientistForm()
        {
            InitializeComponent();
        }

        public ScientistForm(BaseForm caller)
        {
            this.caller = caller;
            caller.Hide();
            InitializeComponent();
        }

        public ScientistForm(BaseForm caller, DbAppContext db)
        {
            this.caller = caller;
            caller.Hide();
            this.db = db;
            InitializeComponent();
        }

        private void ScientistForm_Load(object sender, EventArgs e)
        {
            initData();
        }

        private  void initData()
        {
            if (db == null)
                db = new DbAppContext();

            scientistController = new ScientistController(db);

            crud = new ScientistCrud(db);

           // formDTO = new CUParticipantFormDTO();
           // formDTO.contex = db;

            filter = new ScientistFilter();

            CheckBoxDataInit dataInit = new CheckBoxDataInit(db);

            dataInit.addCompanies(cbCompany);
            dataInit.addCountries(cbCountry);
            dataInit.addDegrees(cbDegree);

            dataGridView1.DataSource = db.ViewScientists.ToList();
        }


        private void ScientistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = scientistController.GetScientists(filter);
        }

        private void resetData()
        {
            cbCompany.SelectedIndex = 0;
            cbCountry.SelectedIndex = 0;
            cbDegree.SelectedIndex = 0;

            filter.company = 0;
            filter.country = 0;
            filter.degree = 0;

            dataGridView1.DataSource = db.ViewScientists.ToList();
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void cbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            academicDegree d = (academicDegree)cbDegree.SelectedItem;
            filter.degree = d.degreeId;
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            country c = (country)cbCountry.SelectedItem;
            filter.country = c.countryId;
        }

        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            company c = (company)cbCompany.SelectedItem;
            filter.company = c.companyId;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
