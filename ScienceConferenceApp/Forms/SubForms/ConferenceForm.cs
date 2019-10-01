using ScienceConferenceApp.Forms.Utils;
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
        }

        BaseForm caller;
        public ConferenceForm(BaseForm form)
        {
            caller = form;
            form.Hide();
            InitializeComponent();
        }

        private void ConferenceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'subjectDataSet.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.subjectDataSet.subjects);
            // TODO: This line of code loads data into the 'conferencesDataSet.conferences' table. You can move, or remove it, as needed.
            this.conferencesTableAdapter.Fill(this.conferencesDataSet.conferences);
            // TODO: This line of code loads data into the 'conferencesAndParticipantsDataSet.ViewConferencesWithParticipants' table. You can move, or remove it, as needed.
            this.viewConferencesWithParticipantsTableAdapter.Fill(this.conferencesAndParticipantsDataSet.ViewConferencesWithParticipants);

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
            cbConference.SelectedIndex = 0;
            cbSubject.SelectedIndex = 0;
            cbTheme.SelectedIndex = 0;
        }
    }
}
