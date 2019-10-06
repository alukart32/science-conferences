using ScienceConferenceApp.Controllers;
using ScienceConferenceApp.CRUD.Model.DTO;
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
    public partial class ConferenceForm : BaseForm
    {
        public ConferenceForm()
        {
            InitializeComponent();
            initData();
        }

        BaseForm caller;
        ConferenceController conferenceController;
        ConferenceFilter filter;

        ConferenceCrud conferenceCrud;

        CUConferenceFormDTO formDTO;
        DbAppContext db;
        
        public ConferenceForm(BaseForm form)
        {
            caller = form;
            form.Hide();
            InitializeComponent();
        }

        private void initData()
        {
            db = new DbAppContext();
            conferenceController = new ConferenceController(db);
            filter = new ConferenceFilter();

            conferenceCrud = new ConferenceCrud(db);

            formDTO = new CUConferenceFormDTO();
            formDTO.contex = db;
            
            CheckBoxDataInit dataInit = new CheckBoxDataInit(db);

            filter.date = DateTime.Now;
            dataInit.addConferences(cbConference);
            dataInit.addAddresses(cbAddress);
            dataInit.addCountries(cbCountry);

            dataGridView1.DataSource = db.ViewConferences.ToList();
        }

        private void ConferenceForm_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void ConferenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {          
            resetData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conferenceController.GetConferences(filter);
        }

        private void cbConference_SelectedIndexChanged(object sender, EventArgs e)
        {
            conference c = (conference)cbConference.SelectedItem;
            filter.conference = c.conferenceId;
        }
        private void cbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            address a = (address)cbAddress.SelectedItem;
            filter.address = a.addressId;
        }
        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            country c = (country)cbCountry.SelectedItem;
            filter.country = c.countryId;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = conferenceController.GetDate(dateTimePicker.Value);
            filter.date = dateTimePicker.Value;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conference c = new conference();

            c.conferenceId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["conferenceId"].Value);

            // picking date
            //if(e.ColumnIndex == 3)
            //{
            //    dateTimePicker.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["date"].Value);
            //    filter.date = dateTimePicker.Value;
            //}


            // updating
            if(e.ColumnIndex == 5)
            {
                formDTO.op = CrudOpr.Update;

                conference findConf = db.conferences.Find(c.conferenceId);
                formDTO.obj = findConf;

                CreateUpdateConferenceForm form = new CreateUpdateConferenceForm(this, formDTO);
                form.Show();              
            }

            // deleting
            if (e.ColumnIndex == 6)
            {
                // Запрашиваем подтверждение
                string message = "Do you want to delete?";
                string caption = "Y/n";
                var result = MessageBox.Show(message, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // deleting
                    if (conferenceCrud.delete(c))
                    {
                        MessageBox.Show("Conference was deleted!");
                        resetData();
                    }
                    else MessageBox.Show("Deleting was denied");
                }
            }
        }

        private void AddConferenceButton_Click(object sender, EventArgs e)
        {
            formDTO.op = CrudOpr.Create;
            CreateUpdateConferenceForm f = new CreateUpdateConferenceForm(this, formDTO);
            f.Show();
            resetData();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetData();
        }

        
        bool isDateInFilterChecked = false;
        
        private void cbDateInFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDateInFilter.Checked && !isDateInFilterChecked)
            {
                filter.withDate = true;
                isDateInFilterChecked = true;
                return;
            }
            else
            {
                cbDateInFilter.CheckState = CheckState.Unchecked;
                isDateInFilterChecked = false;
                filter.withDate = false;
            }

        }

        private void resetData()
        {
            cbConference.SelectedIndex = 0;
            cbAddress.SelectedIndex = 0;
            cbCountry.SelectedIndex = 0;

            dateTimePicker.Value = DateTime.Now;

            filter.address = 0;
            filter.conference = 0;
            filter.country = 0;

            filter.date = DateTime.Now;

            dataGridView1.DataSource = db.ViewConferences.ToList();
        }
    }
}
