using ScienceConferenceApp.Controllers;
using ScienceConferenceApp.CRUD.Model.DTO;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Forms.Crud;
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

        ParticipantFilter filter;

        ParticipantController participantController;

        CUConferenceFormDTO formDTO;

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
            initData();
        }

        private void initData()
        {
            db = new DbAppContext();
            participantController = new ParticipantController(db);
            //filter = new ConferenceFilter();

            //conferenceCrud = new ConferenceCrud(db);

            formDTO = new CUConferenceFormDTO();
            //formDTO.contex = db;

            filter = new ParticipantFilter();

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetData()
        {
            cbConference.SelectedIndex = 0;
            cbTheme.SelectedIndex = 0;
            cbSubject.SelectedIndex = 0;
            cbDegree.SelectedIndex = 0;

            filter.participant = 0;
            filter.subject = 0;
            filter.theme = 0;
            filter.degree = 0;

            dataGridView1.DataSource = db.ViewConferencesWithParticipants.ToList();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = participantController.GetParticipants(filter);
        }

        private void cbConference_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            filter.conference = cbConference.Text;

            // filter.conference = cbConference.Text;
        }

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            theme t = (theme)cbTheme.SelectedItem;
            filter.theme = t.themeId;
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            subject s = (subject)cbSubject.SelectedItem;
            filter.subject = s.subjectId;
        }

        private void cbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            academicDegree s = (academicDegree)cbDegree.SelectedItem;
            filter.degree = s.degreeId;
        }

        private void AddConferenceButton_Click(object sender, EventArgs e)
        {
            formDTO.op = CrudOpr.Create;
        }
    }
}
