using ScienceConferenceApp.CRUD.DTO;
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
    public partial class CreateUpdateScientistForm : BaseForm
    {
        BaseForm caller;

        ScientistDTO dto;

        ScientistCrud crud;

        DbAppContext db;

        CrudOpr crudOp;

        Regex r = new Regex("^[a-zA-Z0-9]*$");

        CUFormDTO<ViewScientist> formDTO;

        CheckBoxDataInit dataInit;

        public CreateUpdateScientistForm()
        {
            InitializeComponent();
        }

        public CreateUpdateScientistForm(BaseForm caller, CUFormDTO<ViewScientist> form)
        {
            this.caller = caller;
            caller.Hide();
            this.formDTO = form;
            this.crudOp = form.op;
            this.db = form.contex;

            InitializeComponent();
        }

        private void initDataForUpdate()
        {
            dto.company = formDTO.obj.companyId;
            dto.country = formDTO.obj.countryId;
            dto.degree = formDTO.obj.degreeId;
            dto.firstName = formDTO.obj.firstName;
            dto.secondName = formDTO.obj.secondName;
            
            cbCompany.Text = formDTO.obj.companyName;
            cbCountry.Text = formDTO.obj.code;
            cbDegree.Text = formDTO.obj.degree;
            FirstNameTextBox.Text = formDTO.obj.firstName;
            SecondNameTextBox.Text = formDTO.obj.secondName;
        }

        private void initBaseData()
        {
            dto = new ScientistDTO();
            crud = new ScientistCrud(db);
            dataInit = new CheckBoxDataInit(db);

            dataInit.addDegrees(cbDegree);
            dataInit.addCountries(cbCountry);
            dataInit.addCompanies(cbCompany);
        }

        private void CreateUpdateScientistForm_Load(object sender, EventArgs e)
        {
            initBaseData();

            if (crudOp == CrudOpr.Update)
            {
                initDataForUpdate();
            }
        }

        private void CreateUpdateScientistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            // check names
            bool isNormalNames = r.IsMatch(dto.firstName) && r.IsMatch(dto.secondName);

            if (!isNormalNames)
            {
                MessageBox.Show("Incorrect names!");
                return;
            }

            doCrud();
        }

        private void doCrud()
        {

            scientist s = new scientist();
            s.firstName = dto.firstName;
            s.secondName = dto.secondName;
            s.academicDegree = dto.degree;
            s.company = dto.company;
            s.country = dto.country;
            
            switch (crudOp)
            {
                // create
                case CrudOpr.Create:
                    if (crud.create(s) != null)
                    {
                        MessageBox.Show("Scientist was added!");
                        this.Close();
                    }
                    else MessageBox.Show("Adding was denied");
                    break;
                case CrudOpr.Update:
                    s.scientistId = formDTO.obj.scientistId;
                    if (crud.update(s))
                    {
                        MessageBox.Show("Scientist was updated!");
                        this.Close();
                    }
                    else MessageBox.Show("Updating was denied");
                    break;
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            country c = (country)cbCountry.SelectedItem;
            dto.country = c.countryId;
        }

        private void cbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            academicDegree d = (academicDegree)cbDegree.SelectedItem;
            dto.degree = d.degreeId;
        }

        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            company c = (company)cbCompany.SelectedItem;
            dto.company = c.companyId;
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            dto.firstName = FirstNameTextBox.Text;
        }

        private void SecondNameTextBox_TextChanged(object sender, EventArgs e)
        {
            dto.secondName = SecondNameTextBox.Text;
        }
    }
}
