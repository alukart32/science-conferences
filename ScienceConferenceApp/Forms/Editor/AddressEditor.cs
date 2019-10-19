using ScienceConferenceApp.CRUD;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceConferenceApp.Forms.Editor
{
    public partial class AddressEditor : Form
    {

        DbAppContext db;
        address address;
        country country;

        AddressCrud crud;

        Regex r = new Regex("^[a-zA-Z0-9]*$");

        public AddressEditor()
        {
            InitializeComponent();
        }

        public AddressEditor(DbAppContext db, address address)
        {
            this.db = db;
            this.address = address;
            crud = new AddressCrud(db);

            InitializeComponent();
        }

        private void AddressEditor_Load(object sender, EventArgs e)
        {
            addressTb.Text = address.address1;
            countryTb.Text = address.country1.code;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (checkData())
            {

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (checkData())
            {

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (checkData())
            {

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private bool checkData()
        {
            if (!r.IsMatch(addressTb.Text))
            {
                MessageBox.Show("Wrong data!");
                return false;
            }
            return true;
        }

        private void EditCountry_Click(object sender, EventArgs e)
        {

        }
    }
}
