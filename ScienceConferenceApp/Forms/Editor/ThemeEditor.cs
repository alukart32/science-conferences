using ScienceConferenceApp.CRUD.Model;
using ScienceConferenceApp.Forms.Utils;
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
    public partial class ThemeEditor : BaseForm
    {

        DbAppContext db;

        // та страна, с которой работать будем
        theme theme;

        ThemeCrud crud;

        Regex r = new Regex("^[a-zA-Z]*$");

        public ThemeEditor(DbAppContext db, theme theme)
        {
            this.db = db;
            this.theme = theme;

            InitializeComponent();
        }

        private void Theme_Editor_Load(object sender, EventArgs e)
        {
            themeTb.Text = theme.themeName;
            crud = new ThemeCrud(db);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (validateData(themeTb.Text))
            {
                theme.themeName = themeTb.Text;

                if (crud.update(theme))
                {
                    MessageBox.Show("Theme was updated!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Theme alredy exists!!!");
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (validateData(themeTb.Text))
            {
                theme t = new theme();
                t.themeName = themeTb.Text;

                if (crud.create(t) != null)
                {
                    MessageBox.Show("Theme was added!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Theme alredy exists!!!");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (crud.delete(theme))
            {
                MessageBox.Show("Theme was deleted!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something goes wrong!!!");
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
                    MessageBox.Show("Wrong data!");
                    return false;
                }
            }

            return true;
        }
    }
}
