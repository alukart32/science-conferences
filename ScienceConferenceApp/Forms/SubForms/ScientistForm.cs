using ScienceConferenceApp.Controllers;
using ScienceConferenceApp.CRUD.DTO.Form;
using ScienceConferenceApp.CRUD.Model;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Forms.Crud;
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

        CUScientistFormDTO formDTO;

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

            formDTO = new CUScientistFormDTO();
            formDTO.contex = db;

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
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["scientistIdDataGridViewTextBoxColumn"].Value);

            // updating
            if (e.ColumnIndex == 6)
            {
                formDTO.op = CrudOpr.Update;

                ViewScientist findScientist = db.ViewScientists.SingleOrDefault(o => o.scientistId == id);
                formDTO.obj = findScientist;

               // CreateUpdateScientistForm form = new CreateUpdateScientistForm(this, formDTO);
                //form.Show();
            }

            // deleting
            if (e.ColumnIndex == 7)
            {
                // Запрашиваем подтверждение
                string message = "Do you want to delete?";
                string caption = "Y/n";
                var result = MessageBox.Show(message, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    scientist s = new scientist();
                    s.scientistId = id;
                    // deleting
                    if (crud.delete(s))
                    {
                        MessageBox.Show("Scientist was deleted!");
                        resetData();
                    }
                    else MessageBox.Show("Deleting was denied");
                }
            }
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
            formDTO.contex = db;
            formDTO.op = CrudOpr.Create;
            formDTO.obj = null;
            CreateUpdateScientistForm form = new CreateUpdateScientistForm(this, formDTO);
            form.Show();
        }
    }
}
