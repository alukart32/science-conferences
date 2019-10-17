﻿using ScienceConferenceApp.CRUD;
using ScienceConferenceApp.CRUD.DTO;
using ScienceConferenceApp.CRUD.Model;
using ScienceConferenceApp.CRUD.Model.DTO.Form;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ScienceConferenceApp.Forms.Crud
{
    public partial class CreateUpdateParticipantForm : BaseForm
    {
        BaseForm caller;

        ParticipantDTO participantDTO;

        ParticipantCrud crud;
        SubjectCrud subjectCrud;

        DbAppContext db;

        CrudOpr currentCrudOp;

        Regex r = new Regex("^[a-zA-Z0-9]*$");

        CUFormDTO<ViewConferencesWithParticipant> formDTO;

        // for adding
        public ViewScientist scientist;

        CheckBoxDataInit dataInit;

        public CreateUpdateParticipantForm(BaseForm form, CUFormDTO<ViewConferencesWithParticipant> formDTO)
        {
            caller = form;
            form.Hide();
            InitializeComponent();

            this.db = formDTO.contex;
            participantDTO = new ParticipantDTO();

            crud = new ParticipantCrud(db);
            subjectCrud = new SubjectCrud(db);

            currentCrudOp = formDTO.op;

            this.formDTO = formDTO;

            isChecked = false;
        }

        public CreateUpdateParticipantForm()
        {
            InitializeComponent();
        }

        private void CreateUpdateParticipantForm_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void initDataForUpdate(ViewConferencesWithParticipant obj)
        {
            ScientistLabel.Text = formDTO.obj.firstName + " " + formDTO.obj.secondName + ","
                                               + formDTO.obj.degree + "\n"
                                               + formDTO.obj.companyName;

            ChooseScientistButton.Visible = false;


            cbConference.Text = obj.conferenceName;
            cbTheme.Text = obj.themeName;
            cbSubject.Text = obj.subject;

            cbPublication.CheckState = obj.publication.Equals("y") ? CheckState.Checked : CheckState.Unchecked;
            if (cbPublication.CheckState == CheckState.Checked)
                isChecked = true;

            participantDTO.conference = obj.conferenceId;
            participantDTO.subject = obj.subjectId;
            participantDTO.theme = obj.themeId;
        }

        private void initData()
        {
            dataInit = new CheckBoxDataInit(db);

            dataInit.addConferences(cbConference);
            dataInit.addThemes(cbTheme);
            dataInit.addSubjects(cbSubject);

            switch (currentCrudOp)
            {
                case CrudOpr.Update:
                    initDataForUpdate(formDTO.obj);
                    break;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            checkData();

            participant p = new participant();

            p.conference = participantDTO.conference;
            p.subject = participantDTO.subject;
            p.theme = participantDTO.theme;
            p.publication = isChecked ? "y" : "n";
            

            switch (currentCrudOp)
            {
                case CrudOpr.Update:                 
                    p.scientist = formDTO.obj.scientistId;
                    p.participantId = formDTO.obj.participantId;
                    break;
                case CrudOpr.Create:
                    p.scientist = scientist.scientistId;
                    break;
            }

            doCrud(p);
        }

        private void doCrud(participant p)
        {
            switch (currentCrudOp)
            {
                // create
                case CrudOpr.Create:
                    if (crud.create(p) != null)
                    {
                        MessageBox.Show("Conference was added!");
                        this.Close();
                    }
                    else MessageBox.Show("Adding was denied");
                    break;
                case CrudOpr.Update:

                    if (crud.update(p))
                    {
                        MessageBox.Show("Conference was updated!");
                        this.Close();
                    }
                    else MessageBox.Show("Updating was denied");
                    break;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChooseScientistButton_Click(object sender, EventArgs e)
        {
            // go to choose a scientist for participant
            ChooseScientistForm chooseScientist = new ChooseScientistForm(this, db);
            chooseScientist.Show();
        }

        private void CreateUpdateParticipantForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void cbConference_SelectedIndexChanged(object sender, EventArgs e)
        {
            conference c = (conference)cbConference.SelectedItem;
            participantDTO.conference = c.conferenceId;
        }

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            theme t = (theme)cbTheme.SelectedItem;
            participantDTO.theme = t.themeId;
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            subject s = (subject)cbSubject.SelectedItem;
            participantDTO.subject = s.subjectId;
        }

        bool isChecked;
        private void cbPublication_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPublication.Checked && !isChecked)
            {
                isChecked = true;
                cbPublication.CheckState = CheckState.Checked;
                return;
            }
            else
            {
                cbPublication.CheckState = CheckState.Unchecked;
                isChecked = false;
            }
        }

        private void checkData()
        {
            int prod = participantDTO.conference * participantDTO.subject * participantDTO.theme;

            if (prod == 0 && cbSubject.Text == "")
            {
                MessageBox.Show("Nothing was selected!");
                return;
            }

            switch (currentCrudOp)
            {
                case CrudOpr.Create:
                    if (scientist == null)
                    {
                        MessageBox.Show("Scientist wasn't selected!");
                        return;
                    }
                    break;
            }

            // possible new subject
            if(cbSubject.Text == "")
            {
                MessageBox.Show("Subject wasn't selected!");
                return;
            }

            checkNewSubject();


            // possible new theme
            if (cbTheme.Text == "")
            {
                MessageBox.Show("Theme wasn't selected!");
                return;
            }

            checkNewTheme();
        }

        private void checkNewTheme()
        {
            throw new NotImplementedException();
        }

        private void checkNewSubject()
        {
            // check on a unique

            List<subject> all = new List<subject>();
            all.AddRange(db.subjects);

            all = all.FindAll
                (
                    delegate (subject s)
                    { return s.subject1.Equals(cbSubject.Text); }
                );

            if (all.Count == 0)
            {
                // create a new address
                subject s = new subject();
                s.subject1 = cbSubject.Text;
               
                subject saved = subjectCrud.create(s);

                participantDTO.subject = saved.subjectId;
            }
        }
    }
}
