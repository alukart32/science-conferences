using ScienceConferenceApp.CRUD;
using ScienceConferenceApp.Forms.DTO;
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
    public partial class CountryEditor : Form
    {
        DbAppContext db;

        // та страна, с которой работать будем
        country country;

        CountryCrud crud;

        Regex r = new Regex("^[a-zA-Z]*$");

        bool forUpdate = false;

        public CountryEditor()
        {
            InitializeComponent();
        }

        public CountryEditor(DbAppContext db, country country)
        {
            this.db = db;
            this.country = country;
           // this.forUpdate = true;
            this.crud = new CountryCrud(db);

            InitializeComponent();
        }

        private void CountryEditor_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void initData()
        {
           countryTb.Text = country.code;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (validateData(countryTb.Text))
            {
                country.code = countryTb.Text;

                if (crud.update(country))
                {
                    MessageBox.Show("Country was updated!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Country alredy exists!!!");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (crud.delete(country))
            {
                MessageBox.Show("Country was deleted!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something goes wrong!!!");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (validateData(countryTb.Text))
            {
                country c = new country();
                c.code = countryTb.Text;

                if (crud.create(c) != null)
                {
                    MessageBox.Show("Country was added!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Country alredy exists!!!");
                }
            }
        }

        private bool validateData(string str)
        {
            if (!r.IsMatch(str))
            {
                if(!str.Contains(" "))
                {
                    MessageBox.Show("Wrong data!");
                    return false;
                }
            }

            return true;
        }

        private void CountryEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            forUpdate = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
