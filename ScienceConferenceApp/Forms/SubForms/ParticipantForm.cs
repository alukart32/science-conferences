using ScienceConferenceApp.DataInitializer;
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
        }

        private void ParticipantForm_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void initData()
        {
            db = new DbAppContext();
            //conferenceController = new ConferenceController();
            //filter = new ConferenceFilter();

            //conferenceCrud = new ConferenceCrud(db);

            //formDTO = new CUConferenceFormDTO();
            //formDTO.contex = db;

            CheckBoxDataInit dataInit = new CheckBoxDataInit(db);

            dataInit.addConferences(cbConference);
            dataInit.addThemes(cbTheme);
            dataInit.addSubjects(cbSubject);
            dataInit.addDegrees(cbDegree);

            dataGridView1.DataSource = db.ViewConferencesWithParticipants.ToList();
        }

        private void ParticipantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void conferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConferenceForm conferenceForm = new ConferenceForm(this);
            conferenceForm.Show();
        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
