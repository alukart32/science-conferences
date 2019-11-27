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

            List<country> countries = new List<country>();
            countries.AddRange(db.countries);

            countryCB.DataSource = countries;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (validateData(addressTb.Text))
            {
                address.address1 = addressTb.Text;
                country c = (country)countryCB.SelectedItem;
                address.country = c.countryId;

                if (crud.update(address))
                {
                    MessageBox.Show("Address was updated!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Address alredy exists!!!");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (crud.delete(address))
            {
                MessageBox.Show("Address was deleted!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something goes wrong!!!");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (validateData(addressTb.Text))
            {
                address a = new address();
                a.country = country.countryId;
                a.address1 = addressTb.Text;

                if (crud.create(a) != null)
                {
                    MessageBox.Show("Address was added!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Address alredy exists!!!");
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateData(string str)
        {
            if (!r.IsMatch(str))
            {
                if (!str.Contains(" "))
                {
                    if (!str.Contains("-"))
                    {
                        if (!str.Contains("."))
                        {
                            MessageBox.Show("Wrong data!");
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void EditCountry_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void countryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            country = (country)countryCB.SelectedItem;
        }
    }
}
