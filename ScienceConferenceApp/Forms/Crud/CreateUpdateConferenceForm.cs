using ScienceConferenceApp.Controllers;
using ScienceConferenceApp.CRUD;
using ScienceConferenceApp.CRUD.Model.DTO;
using ScienceConferenceApp.CRUD.Model.DTO.Form;
using ScienceConferenceApp.CRUD.Utils;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Forms.DTO;
using ScienceConferenceApp.Forms.Editor;
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

        CrudOpr currentCrudOp;

        Regex r = new Regex("^[a-zA-Z0-9]*$");

        CUFormDTO<conference> formDTO;

        AddressCrud addressCrud;
        CountryCrud countryCrud;

        bool newCountry = false;

        public CreateUpdateConferenceForm(BaseForm form, CUFormDTO<conference> formDTO)
        {
            caller = form;
            form.Hide();
            InitializeComponent();

            this.db = formDTO.contex;
            conferenceDTO = new ConferenceDTO();
            crud = new ConferenceCrud(db);

            addressCrud = new AddressCrud(db);
            countryCrud = new CountryCrud(db);

            currentCrudOp = formDTO.op;
            this.formDTO = formDTO;
          
            switch (currentCrudOp)
            {
                case CrudOpr.Update:
                    initDataForUpdate(formDTO.obj);
                    break;
                default:
                    formDTO.obj.date = DateTime.Now;
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
            List<address> addresses = new List<address>();
            addresses.AddRange(db.addresses);

            cbAddress.DataSource = addresses;

            List<country> countries = new List<country>();
            countries.AddRange(db.countries);

            cbCountry.DataSource = countries;

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

            checkData();
        
            c.conferenceName = conferenceDTO.name;
            c.address = conferenceDTO.address;
            c.date = conferenceDTO.date;
            c.address = conferenceDTO.address;

            doCrud(c);  
        }

        private void doCrud(conference c)
        {
            switch (currentCrudOp)
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

                    if (crud.updateWithCountry(c, newCountry))
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
            switch (currentCrudOp)
            {
                case CrudOpr.Create:
                    tbConferenceName.Text = "";
                    break;
            }
           
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            country c = (country)cbCountry.SelectedItem;
            conferenceDTO.country = c.countryId;

            List<address> all = new List<address>();
            all.AddRange(c.addresses);

            if (all.Count == 0)
                cbAddress.Text = "";

            cbAddress.DataSource = all;
        }

        // checking all data for conference
        private void checkData()
        {
            // check name
            if (r.IsMatch(tbConferenceName.Text))
                conferenceDTO.name = tbConferenceName.Text;
            else
            {
                if (currentCrudOp != CrudOpr.Update)
                    tbConferenceName.Text = "";
                else
                    tbConferenceName.Text = conferenceDTO.name;

                MessageBox.Show("Incorrect conference name!");

                return;
            }

            // check data
            if (conferenceDTO.date == DateTime.MinValue)
                conferenceDTO.date = DateTime.Now;

            // Does user want to add a new address?
            checkNewCountry();
            checkNewAddress();       
        }

        private void checkNewAddress()
        {
            // creating of a new address

            // check possible address
            if (!r.IsMatch(cbAddress.Text))
            {
                if (!cbAddress.Text.Contains(" "))
                {
                    MessageBox.Show("Incorect address!");
                    return;
                }
            }

            // check on a unique

            List<address> all = new List<address>();
            all.AddRange(db.addresses);

            all = all.FindAll
                (
                    delegate (address a)
                    { return a.address1.Equals(cbAddress.Text); }
                );

            if (all.Count == 0)
            {
                // create a new address
                address a = new address();
                a.address1 = cbAddress.Text;
                a.country = conferenceDTO.country;

                a = addressCrud.create(a);

                conferenceDTO.address = a.addressId;
            }         
        }

        private void checkNewCountry()
        {
            // creating of a new address

            // check possible address
            if (!r.IsMatch(cbCountry.Text))
            {
                if (!cbCountry.Text.Contains(" "))
                {
                    if (cbCountry.Text.Length > 50)
                    {
                        MessageBox.Show("Incorect address!");
                        return;
                    }
                }
            }

            // check on a unique

            List<country> all = new List<country>();
            all.AddRange(db.countries);

            all = all.FindAll
                (
                    delegate (country c)
                    { return c.code.Equals(cbCountry.Text); }
                );

            if (all.Count == 0)
            {
                // create a new address
                country c = new country();
                c.code = cbCountry.Text;

                c = countryCrud.create(c);

                conferenceDTO.country = c.countryId;
                newCountry = true;
            }
            else
                newCountry = false;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddressEditor editor = new AddressEditor(db, (address)cbAddress.SelectedItem);
            editor.Show();
        }

        private void cbCountry_TextChanged(object sender, EventArgs e)
        {
            cbAddress.Text = "";

            List<address> a = new List<address>();
           
            a.Add(new address());
            cbAddress.DataSource = a;
        }
    }
}
