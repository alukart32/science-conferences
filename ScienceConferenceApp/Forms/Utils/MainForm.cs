using ScienceConferenceApp.CRUD.DTO.Form;
using ScienceConferenceApp.CRUD.Model.DTO.Form;
using ScienceConferenceApp.Forms.DTO;
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
        DataFormDTO dataFormDTO;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataFormDTO = new DataFormDTO();
            dataFormDTO.db = new DbAppContext();

            dataFormDTO.caller = this;
            dataFormDTO.mainForm = this;
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
            ConferenceForm conferenceForm = new ConferenceForm(dataFormDTO);
            conferenceForm.Show();
        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParticipantForm participantForm = new ParticipantForm(dataFormDTO);
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
            ScientistForm scientist = new ScientistForm(dataFormDTO);
            scientist.Show();
        }
    }
}
