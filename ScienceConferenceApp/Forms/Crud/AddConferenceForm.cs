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
    public partial class AddConferenceForm : BaseForm
    {
        public AddConferenceForm()
        {
            InitializeComponent();
        }

        BaseForm caller;

        ConferenceDTO dto; // as a new object

        ConferenceCrud crud;

        DbAppContext db;

        Regex r = new Regex("^[a-zA-Z0-9]*$");

        public AddConferenceForm(BaseForm form, DbAppContext DB)
        {
            caller = form;
            form.Hide();
            InitializeComponent();

            this.db = DB;
            dto = new ConferenceDTO();
            crud = new ConferenceCrud(db);

            List<address> addresses = new List<address>();
            addresses.AddRange(db.addresses);

            cbAddress.DataSource = addresses;
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
                dto.name = tbConferenceName.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            address a = (address)cbAddress.SelectedItem;
            dto.address = a.addressId;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dto.date = dateTimePicker.Value;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            conference c = new conference();

            if (r.IsMatch(tbConferenceName.Text))
                dto.name = tbConferenceName.Text;
            else
            {
                tbConferenceName.Text = "";
                return;
            }

            c.conferenceName = dto.name;
            c.address = dto.address;
            c.date = dto.date;

            if (crud.create(c) != null)
            {
                MessageBox.Show("Conference was added!");
                this.Close();
            }
            else MessageBox.Show("Adding was denied");
        }

        private void tbConferenceName_Click(object sender, EventArgs e)
        {
            tbConferenceName.Text = "";
        }
    }
}
