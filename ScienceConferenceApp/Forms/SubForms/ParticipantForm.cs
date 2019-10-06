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
    public partial class ParticipantForm : BaseForm
    {

        BaseForm caller;
        DbAppContext db;

        public ParticipantForm()
        {
            InitializeComponent();
        }

        public ParticipantForm(BaseForm form)
        {
            caller = form;
            form.Hide();
            InitializeComponent();
            db = new DbAppContext();

            dataGridView1.DataSource = db.ViewConferencesWithParticipants.ToList();
        }

        private void ParticipantForm_Load(object sender, EventArgs e)
        {
          
        }

        private void ParticipantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
