using ScienceConferenceApp.Controllers;
using ScienceConferenceApp.CRUD;
using ScienceConferenceApp.CRUD.DTO.Form;
using ScienceConferenceApp.CRUD.Model.DTO;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Forms.Crud;
using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Forms.Utils.Menu;
using ScienceConferenceApp.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScienceConferenceApp.Forms.SubForms
{
    public partial class ParticipantForm : BaseForm
    {

        BaseForm caller;
        BaseForm mainForm;

        DbAppContext db;

        ParticipantFilter filter;

        ParticipantController participantController;

        ParticipantCrud crud;

        CUParticipantFormDTO formDTO;

        public ParticipantForm()
        {
            InitializeComponent();
        }

        public ParticipantForm(BaseForm form, BaseForm mainForm, DbAppContext db)
        {
            caller = form;
            form.Hide();
            this.db = db;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void ParticipantForm_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void initData()
        {
            participantController = new ParticipantController(db);
            //filter = new ConferenceFilter();

            crud = new ParticipantCrud(db);

            formDTO = new CUParticipantFormDTO();
            formDTO.contex = db;

            filter = new ParticipantFilter();

            CheckBoxDataInit dataInit = new CheckBoxDataInit(db);

            dataInit.addConferences(cbConference);
            dataInit.addThemes(cbTheme);
            dataInit.addSubjects(cbSubject);
            dataInit.addDegrees(cbDegree);

            //dataGridView1.DataSource = db.ViewConferencesWithParticipants.ToList();
        }

        private void ParticipantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!menuClicked)
                caller.Show();
            else
                mainForm.Show();
        }

        private void conferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConferenceForm conferenceForm = new ConferenceForm(this, mainForm, db);
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

            filter.conference = 0;
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
            conference c = (conference)cbConference.SelectedItem;
            filter.conference = c.conferenceId;
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
            CreateUpdateParticipantForm form = new CreateUpdateParticipantForm(this, formDTO);
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["participantIdDataGridViewTextBoxColumn"].Value);

            // updating
            if (e.ColumnIndex == 9)
            {
                formDTO.op = CrudOpr.Update;

                ViewConferencesWithParticipant findParticipant = db.ViewConferencesWithParticipants.SingleOrDefault(o=>o.participantId == id);
                formDTO.obj = findParticipant;

                CreateUpdateParticipantForm form = new CreateUpdateParticipantForm(this, formDTO);
                form.Show();
            }

            // deleting
            if (e.ColumnIndex == 10)
            {
                // Запрашиваем подтверждение
                string message = "Do you want to delete?";
                string caption = "Y/n";
                var result = MessageBox.Show(message, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    participant participant = new participant();
                    participant.participantId = id;
                    // deleting
                    if (crud.delete(participant))
                    {
                        MessageBox.Show("Conference was deleted!");
                        resetData();
                    }
                    else MessageBox.Show("Deleting was denied");
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm(this);
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ContactForm form = new ContactForm(this);
            form.Show();
        }

        private void scientistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScientistForm form = new ScientistForm(this, mainForm, db);
            form.Show();
        }

        bool menuClicked = false;
        private void toolStripDropDownButton1_ButtonClick(object sender, EventArgs e)
        {
            mainForm.Show();
            menuClicked = true;

            this.Close();
        }
    }
}
