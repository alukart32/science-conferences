using ScienceConferenceApp.CRUD.Model;
using ScienceConferenceApp.CRUD.Model.DTO.Form;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ScienceConferenceApp.Forms.Crud
{
    public partial class CreateUpdateScientistForm : Form
    {
        BaseForm caller;

        ScientstDTO scientistDTO;

        ScientistCrud crud;

        DbAppContext db;

        CrudOpr currentCrudOp;

        Regex r = new Regex("^[a-zA-Z0-9]*$");

        CUFormDTO<ViewScientist> formDTO;

        CheckBoxDataInit dataInit;

        public CreateUpdateScientistForm()
        {
            InitializeComponent();
        }

        private void CreateUpdateScientistForm_Load(object sender, EventArgs e)
        {

        }
    }
}
