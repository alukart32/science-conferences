using ScienceConferenceApp.CRUD.DTO.Form;
using ScienceConferenceApp.CRUD.Model.DTO.Form;
using ScienceConferenceApp.Forms.SubForms;
using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Forms.Utils.Menu;
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

namespace ScienceConferenceApp.Forms
{
    public partial class MainForm : BaseForm
    {
        DbAppContext db;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            db = new DbAppContext();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm(this);
            contactForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm(this);
            helpForm.Show();
        }

        private void conferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConferenceForm conferenceForm = new ConferenceForm(this, this, db);
            conferenceForm.Show();
        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParticipantForm participantForm = new ParticipantForm(this, this, db);
            participantForm.Show();
        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
      //      CompanyForm companyForm = new CompanyForm(this);
      //      companyForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this);
            searchForm.Show();
        }

        private void scientistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScientistForm scientist = new ScientistForm(this,this, db);
            scientist.Show();
        }
    }
}
