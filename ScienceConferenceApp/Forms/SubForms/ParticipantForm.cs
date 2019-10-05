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
    public partial class ParticipantForm : BaseForm
    {

        BaseForm caller;

        public ParticipantForm()
        {
            InitializeComponent();
        }

        public ParticipantForm(BaseForm form)
        {
            caller = form;
            form.Hide();
            InitializeComponent();
        }

        private void ParticipantForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scienceConferencesParticipantsDataSet.ViewConferencesWithParticipants' table. You can move, or remove it, as needed.
            this.viewConferencesWithParticipantsTableAdapter.Fill(this.scienceConferencesParticipantsDataSet.ViewConferencesWithParticipants);

        }

        private void ParticipantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }
    }
}
