using ScienceConferenceApp.CRUD;
using ScienceConferenceApp.CRUD.DTO;
using ScienceConferenceApp.CRUD.Model.DTO.Form;
using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Text.RegularExpressions;

namespace ScienceConferenceApp.Forms.Crud
{
    public partial class CreateUpdateParticipantForm : BaseForm
    {
        BaseForm caller;

        ParticipantDTO participantDTO; // as a new object

        ParticipantCrud crud;

        DbAppContext db;

        CrudOpr currentCrudOp;

        Regex r = new Regex("^[a-zA-Z0-9]*$");

        CUFormDTO<participant> formDTO;

        public CreateUpdateParticipantForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateUpdateParticipantForm_Load(object sender, EventArgs e)
        {

        }
    }
}
