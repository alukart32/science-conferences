using ScienceConferenceApp.Controllers;
using ScienceConferenceApp.CRUD.Model.DTO;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ScienceConferenceApp.Forms.Crud
{
    public partial class CreateUpdateConferenceForm : BaseForm
    {
        public CreateUpdateConferenceForm()
        {
            InitializeComponent();
        }

        BaseForm caller;

        ConferenceDTO conferenceDTO; // as a new object

        ConferenceCrud crud;

        DbAppContext db;

        CrudOpr currentOp;

        Regex r = new Regex("^[a-zA-Z0-9]*$");

        CUConferenceFormDTO formDTO;

        public CreateUpdateConferenceForm(BaseForm form, CUConferenceFormDTO formDTO)
        {
            caller = form;
            form.Hide();
            InitializeComponent();

            this.db = formDTO.contex;
            conferenceDTO = new ConferenceDTO();
            crud = new ConferenceCrud(db);
            
            List<address> addresses = new List<address>();
            addresses.AddRange(db.addresses);

            cbAddress.DataSource = addresses;

            currentOp = formDTO.op;
            this.formDTO = formDTO;

            switch (currentOp)
            {
                case CrudOpr.Update:
                    initDataForUpdate(formDTO.obj);
                    break;
            }
        }

        private void initDataForUpdate(conference obj)
        {
            tbConferenceName.Text = obj.conferenceName;
            cbAddress.SelectedValue = obj.address;
            dateTimePicker.Value = obj.date;
        }

        private void AddConferenceForm_Load(object sender, EventArgs e)
        {
        }

        private void AddConferenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbConferenceName_TextChanged(object sender, EventArgs e)
        {
            if (r.IsMatch(tbConferenceName.Text))
                conferenceDTO.name = tbConferenceName.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            address a = (address)cbAddress.SelectedItem;
            conferenceDTO.address = a.addressId;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            conferenceDTO.date = dateTimePicker.Value;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            conference c = new conference();

            if (r.IsMatch(tbConferenceName.Text))
                conferenceDTO.name = tbConferenceName.Text;
            else
            {
                tbConferenceName.Text = "";
                return;
            }

            c.conferenceName = conferenceDTO.name;
            c.address = conferenceDTO.address;
            c.date = conferenceDTO.date;

            doCrud(c);

            
        }

        private void doCrud(conference c)
        {
            switch (currentOp)
            {
                // create
                case CrudOpr.Create:
                    if (crud.create(c) != null)
                    {
                        MessageBox.Show("Conference was added!");
                        this.Close();
                    }
                    else MessageBox.Show("Adding was denied");
                    break;
                case CrudOpr.Update:

                    c.conferenceId = formDTO.obj.conferenceId;
                    if (crud.update(c))
                    {
                        MessageBox.Show("Conference was updated!");
                        this.Close();
                    }
                    else MessageBox.Show("Updating was denied");
                    break;
            }
        }

        private void tbConferenceName_Click(object sender, EventArgs e)
        {
            switch (currentOp)
            {
                case CrudOpr.Create:
                    tbConferenceName.Text = "";
                    break;
            }
           
        }
    }
}
