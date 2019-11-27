using ScienceConferenceApp.Controllers;
using ScienceConferenceApp.CRUD.DTO.Form;
using ScienceConferenceApp.CRUD.Model;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Forms.Crud;
using ScienceConferenceApp.Forms.DTO;
using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Forms.Utils.Menu;
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
        DataFormDTO dataFormDTO;

        private ScientistController scientistController;
        private ScientistCrud crud;
        ScientistFilter filter;

        CUScientistFormDTO formDTO;

        public ScientistForm()
        {
            InitializeComponent();
        }

        public ScientistForm(DataFormDTO dataFormDTO)
        {
            this.dataFormDTO = dataFormDTO;
            dataFormDTO.caller.Hide();
            InitializeComponent();
        }

        private void ScientistForm_Load(object sender, EventArgs e) => initData();

        private  void initData()
        {
            scientistController = new ScientistController(dataFormDTO.db);

            crud = new ScientistCrud(dataFormDTO.db);

            formDTO = new CUScientistFormDTO();
            formDTO.contex = dataFormDTO.db;

            filter = new ScientistFilter();

            CheckBoxDataInit dataInit = new CheckBoxDataInit(dataFormDTO.db);

            dataInit.addCompanies(cbCompany);
            dataInit.addCountries(cbCountry);
            dataInit.addDegrees(cbDegree);

            if (!(dataFormDTO.userData.userRole == UserRole.ADMIN
                || dataFormDTO.userData.userRole == UserRole.SCIENTIST_MANGER))
            {
                AddButton.Visible = false;
                updateScientist.Visible = false;
                deleteScientist.Visible = false;
            }
            else
            {
                AddButton.Visible = true;
                updateScientist.Visible = true;
                deleteScientist.Visible = true;
            }

            //dataGridView1.DataSource = db.ViewScientists.ToList();
        }


        private void ScientistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!menuClicked)
                dataFormDTO.caller.Show();
            else
                dataFormDTO.mainForm.Show();
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

                ViewScientist findScientist = dataFormDTO.db.ViewScientists.SingleOrDefault(o => o.scientistId == id);
                formDTO.obj = findScientist;

                CreateUpdateScientistForm form = new CreateUpdateScientistForm(this, formDTO);
                form.Show();

                dataGridView1.DataSource = dataFormDTO.db.ViewScientists.ToList();
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

            dataGridView1.DataSource = dataFormDTO.db.ViewScientists.ToList();
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            int f = cbCompany.SelectedIndex + cbCountry.SelectedIndex + cbDegree.SelectedIndex;

            if(f == 0)
            {
                resetData();
            }
            else
            {
                dataGridView1.DataSource = scientistController.GetScientists(filter);
            }
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
            formDTO.contex = dataFormDTO.db;
            formDTO.op = CrudOpr.Create;
            formDTO.obj = null;
            CreateUpdateScientistForm form = new CreateUpdateScientistForm(this, formDTO);
            form.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm(this);
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ContactForm form = new ContactForm(this);
            form.Show();
        }

        bool menuClicked = false;

        private void toolStripDropDownButton1_ButtonClick(object sender, EventArgs e)
        {
            dataFormDTO.mainForm.Show();
            menuClicked = true;
            this.Close();
        }

        private void conferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataFormDTO dto = new DataFormDTO(this, dataFormDTO.mainForm, dataFormDTO.db, dataFormDTO.userData);
            ConferenceForm form = new ConferenceForm(dto);
            form.Show();
        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataFormDTO dto = new DataFormDTO(this, dataFormDTO.mainForm, dataFormDTO.db, dataFormDTO.userData);
            ParticipantForm form = new ParticipantForm(dto);
            form.Show();
        }
    }
}
