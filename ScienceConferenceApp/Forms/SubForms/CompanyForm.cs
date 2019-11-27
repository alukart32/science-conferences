using ScienceConferenceApp.Controllers;
using ScienceConferenceApp.CRUD.DTO.Form;
using ScienceConferenceApp.CRUD.Model;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Forms.Crud;
using ScienceConferenceApp.Forms.DTO;
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
    public partial class CompanyForm : BaseForm
    {
        DataFormDTO dto;
        CheckBoxDataInit checkBoxData;
        CompanyFilter filter;

        CompanyController controller;

        CUCompanyFormDTO formDTO;

        CompanyCrud crud;

        public CompanyForm()
        {
            InitializeComponent();
        }

        public CompanyForm(DataFormDTO dto)
        {
            this.dto = dto;
            dto.caller.Hide();

            checkBoxData = new CheckBoxDataInit(dto.db);
            filter = new CompanyFilter();
            controller = new CompanyController(dto.db);
            crud = new CompanyCrud(dto.db);

            formDTO = new CUCompanyFormDTO();

            InitializeComponent();
        }


        private void CompanyForm_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void initData()
        {
            formDTO.contex = dto.db;

            checkBoxData.addCountries(cbCountry);

            dataGridView1.DataSource = dto.db.ViewCompanies.ToList();

            if (!(dto.userData.userRole == UserRole.ADMIN))
            {
                AddButton.Visible = false;
                update.Visible = false;
                remove.Visible = false;
            }
            else
            {
                AddButton.Visible = true;
                update.Visible = true;
                remove.Visible = true;
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            country c = (country)cbCountry.SelectedItem;
            filter.countryId = c.countryId;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.GetCompanies(filter);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resetCbData();
        }

        private void resetCbData()
        {
            cbCountry.SelectedIndex = 0;

            filter.countryId = 0;

            dataGridView1.DataSource = dto.db.ViewCompanies.ToList();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (cbCountry.SelectedIndex != 0)
            {
                dataGridView1.DataSource = controller.GetCompanies(filter);
            }
            else
            {
                resetCbData();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            formDTO.op = CrudOpr.Create;
            
            CreateUpdateCompanyForm form = new CreateUpdateCompanyForm(this, formDTO);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dto.caller.Show();
        }

        private void toolStripDropDownButton1_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
            dto.mainForm.Show();
        }

        private void conferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataFormDTO d = new DataFormDTO(this, dto.mainForm, dto.db, dto.userData);
            ConferenceForm form = new ConferenceForm(d);
            form.Show();
        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataFormDTO d = new DataFormDTO(this, dto.mainForm, dto.db, dto.userData);
            ParticipantForm form = new ParticipantForm(d);
            form.Show();
        }

        private void scientistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataFormDTO d = new DataFormDTO(this, dto.mainForm, dto.db, dto.userData);
            ScientistForm form = new ScientistForm(d);
            form.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["companyIdDataGridViewTextBoxColumn"].Value);

            // updating
            if (e.ColumnIndex == 3)
            {
                formDTO.op = CrudOpr.Update;

                ViewCompany findCompany = dto.db.ViewCompanies.SingleOrDefault(o => o.companyId == id);
                formDTO.obj = findCompany;

                CreateUpdateCompanyForm form = new CreateUpdateCompanyForm(this, formDTO);
                form.Show();

            }

            // deleting
            if (e.ColumnIndex == 4)
            {
                // Запрашиваем подтверждение
                string message = "Do you want to delete?";
                string caption = "Y/n";
                var result = MessageBox.Show(message, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    company c = new company();
                    c.companyId = id;
                    // deleting
                    if (crud.delete(c))
                    {
                        MessageBox.Show("Company was deleted!");
                        resetCbData();
                    }
                    else MessageBox.Show("Deleting was denied");
                }
            }
        }
    }
}
