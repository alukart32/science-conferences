using ScienceConferenceApp.Controllers;
using ScienceConferenceApp.CRUD.Model.DTO;
using ScienceConferenceApp.CRUD.Model.DTO.Form;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Forms.Crud;
using ScienceConferenceApp.Forms.DTO;
using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Forms.Utils.Menu;
using ScienceConferenceApp.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScienceConferenceApp.Forms.SubForms
{
    public partial class ConferenceForm : BaseForm
    {
        DataFormDTO dataFormDTO;

        ConferenceController conferenceController;
        ConferenceFilter filter;

        ConferenceCrud conferenceCrud;

        CUFormDTO<conference> formDTO;

        public ConferenceForm()
        {
            InitializeComponent();
            initData();
        }

        public ConferenceForm(DataFormDTO dataFormDTO)
        {
            this.dataFormDTO = dataFormDTO;
            dataFormDTO.caller.Hide();
            InitializeComponent();
        }

        private void initData()
        {
            conferenceController = new ConferenceController(dataFormDTO.db);
            filter = new ConferenceFilter();

            conferenceCrud = new ConferenceCrud(dataFormDTO.db);

            formDTO = new CUConferenceFormDTO();
            formDTO.contex = dataFormDTO.db;
            formDTO.obj = new conference();
            formDTO.userData = dataFormDTO.userData;
            
            CheckBoxDataInit dataInit = new CheckBoxDataInit(dataFormDTO.db);

            filter.date = DateTime.Now;
            dataInit.addConferences(cbConference);
            dataInit.addAddresses(cbAddress);
            dataInit.addCountries(cbCountry); 

            if(!(dataFormDTO.userData.userRole == UserRole.ADMIN 
                || dataFormDTO.userData.userRole == UserRole.CONFERENCE_MANAGER))
            {
                AddConferenceButton.Visible = false;

                updButton.Visible = false;
                delButton.Visible = false;
            }
            else
            {
                AddConferenceButton.Visible = true;

                updButton.Visible = true;
                delButton.Visible = true;
            }
                
            //dataGridView1.DataSource = db.ViewConferences.ToList();
        }

        private void ConferenceForm_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void ConferenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!menuClicked)
                dataFormDTO.caller.Show();
            else
                dataFormDTO.mainForm.Show();
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

            // updating
            if(e.ColumnIndex == 5)
            {
                formDTO.op = CrudOpr.Update;

                conference findConf = dataFormDTO.db.conferences.Find(c.conferenceId);
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
            //resetData();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int f = cbAddress.SelectedIndex + cbCountry.SelectedIndex + cbConference.SelectedIndex;

            if (f == 0 && !isDateInFilterChecked)
            {
                resetData();
            }
            else
            {
                dataGridView1.DataSource = conferenceController.GetConferences(filter);
            }

        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataFormDTO dto = new DataFormDTO(this, dataFormDTO.mainForm, dataFormDTO.db, dataFormDTO.userData);
            ParticipantForm participantForm = new ParticipantForm(dto);
            participantForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ContactForm form = new ContactForm(this);
            form.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm(this);
            form.Show();
        }

        private void scientistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataFormDTO dto = new DataFormDTO(this, dataFormDTO.mainForm, dataFormDTO.db, dataFormDTO.userData);
            ScientistForm form = new ScientistForm(dto);
            form.Show();
        }

        bool menuClicked = false;

        private void toolStripDropDownButton1_ButtonClick(object sender, EventArgs e)
        {
            dataFormDTO.mainForm.Show();
            menuClicked = true;
            this.Close();
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

            dataGridView1.DataSource = dataFormDTO.db.ViewConferences.ToList();
        }
    }
}
