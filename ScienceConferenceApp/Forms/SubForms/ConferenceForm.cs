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
        ConferenceViewController conferenceViewController;
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
            conferenceViewController = new ConferenceViewController();
            filter = new ConferenceFilter();

            cbConference.DataSource = db.conferences.ToList();
            cbSubject.DataSource = db.subjects.ToList();      
            cbTheme.DataSource = db.themes.ToList();

            dataGridView1.DataSource = db.ViewConferencesWithParticipants.ToList();
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
            filter.theme = 1;
            filter.subject = 1;
            filter.conference = 2;
            dataGridView1.DataSource = conferenceViewController.GetConferences(filter);

            cbConference.SelectedIndex = 0;
            cbSubject.SelectedIndex = 0;
            cbTheme.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conferenceViewController.GetConferences(filter);
        }

        private void cbConference_SelectedIndexChanged(object sender, EventArgs e)
        {
            conference c = (conference)cbConference.SelectedItem;
            filter.conference = c.conferenceId;
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            subject s = (subject)cbSubject.SelectedItem;
            filter.subject = s.subjectId;
        }

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            theme t = (theme)cbTheme.SelectedItem;
            filter.theme = t.themeId;
        }
    }
}
