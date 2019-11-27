using ScienceConferenceApp.CRUD.Model;
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
    public partial class SubjectEditor : Form
    {
        DbAppContext db;

        subject subject;
        SubjectCrud crud;

        Regex r = new Regex("^[a-zA-Z]*$");

        public SubjectEditor(DbAppContext db, subject subject)
        {
            this.db = db;
            this.subject = subject;
            this.crud = new SubjectCrud(db);

            InitializeComponent();
        }

        private void SubjectEditor_Load(object sender, EventArgs e)
        {
            subjectTb.Text = subject.subject1;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (validateData(subjectTb.Text))
            {
                subject.subject1 = subjectTb.Text;

                if (crud.update(subject))
                {
                    MessageBox.Show("Subject was updated!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Subject alredy exists!!!");
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (validateData(subjectTb.Text))
            {
                subject s = new subject();
                s.subject1 = subjectTb.Text;

                if (crud.create(s) != null)
                {
                    MessageBox.Show("Subject was added!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Subject alredy exists!!!");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (crud.delete(subject))
            {
                MessageBox.Show("Subject was deleted!");
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
