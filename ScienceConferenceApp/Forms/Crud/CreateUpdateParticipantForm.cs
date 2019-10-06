using ScienceConferenceApp.CRUD;
using ScienceConferenceApp.CRUD.DTO;
using ScienceConferenceApp.CRUD.Model.DTO.Form;
using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
