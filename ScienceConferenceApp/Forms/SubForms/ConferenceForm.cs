using ScienceConferenceApp.Controllers;
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
        DbAppContext db;

        public ConferenceForm(BaseForm form)
        {
            caller = form;
            form.Hide();
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            db = new DbAppContext();
            conferenceController = new ConferenceController();
            filter = new ConferenceFilter();

            addConferences();
            addAddresses();
            addCountries();

            dataGridView1.DataSource = db.ViewConferences.ToList();
        }

        private void addConferences()
        {
            conference all = new conference();
            all.conferenceName = "all";
            all.conferenceId = 0;
            List<conference> confs = new List<conference>();
            confs.Add(all);
            confs.AddRange(db.conferences.ToList());

            cbConference.DataSource = confs;
        }

        private void addAddresses()
        {
            address all = new address();
            all.address1 = "all";
            all.addressId = 0;
            List<address> adds = new List<address>();
            adds.Add(all);
            adds.AddRange(db.addresses.ToList());

            cbAddress.DataSource = adds;
        }

        private void addCountries()
        {
            country all = new country();
            all.code = "all";
            all.countryId = 0;
            List<country> cs = new List<country>();
            cs.Add(all);
            cs.AddRange(db.countries.ToList());

            cbCountry.DataSource = cs;
        }

        private void ConferenceForm_Load(object sender, EventArgs e)
        {
            
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
            dataGridView1.DataSource = db.ViewConferences.ToList();

            cbConference.SelectedIndex = 0;
            cbAddress.SelectedIndex = 0;
            cbCountry.SelectedIndex = 0;
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
    }
}
