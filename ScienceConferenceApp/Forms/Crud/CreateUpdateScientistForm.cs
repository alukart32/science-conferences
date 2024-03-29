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
    public partial class CreateUpdateScientistForm : BaseForm
    {
        BaseForm caller;

        ScientistDTO dto;

        ScientistCrud crud;

        DbAppContext db;

        CrudOpr crudOp;

        Regex r = new Regex("^[a-zA-Z]*$");

        CUFormDTO<ViewScientist> formDTO;

        CheckBoxDataInit dataInit;

        CountryCrud countryCrud;

        public CreateUpdateScientistForm()
        {
            InitializeComponent();
        }

        public CreateUpdateScientistForm(BaseForm caller, CUFormDTO<ViewScientist> form)
        {
            this.caller = caller;
            //caller.Hide();
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
            countryCrud = new CountryCrud(db);
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
            checkComboBox();
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

        private void checkComboBox()
        {
            bool isEmptyNames = FirstNameTextBox.Text.Equals("") && SecondNameTextBox.Text.Equals("");
            if (isEmptyNames)
            {
                MessageBox.Show("Incorrect names!");
                return;
            }

            // check names
            bool isNormalNames = r.IsMatch(dto.firstName) && r.IsMatch(dto.secondName);

            if (!isNormalNames)
            {
                MessageBox.Show("Incorrect names!");
                return;
            }

            int prod = cbCompany.SelectedIndex * cbCountry.SelectedIndex * cbDegree.SelectedIndex;
            if (prod == 0)
            {
                MessageBox.Show("Incorrect values!");
                return;
            }

            checkNewDegree();
            checkNewCountry();
        }

        private void checkNewDegree()
        {
            if (!r.IsMatch(cbDegree.Text))
            {
                if (!cbDegree.Text.Contains(" "))
                {
                    MessageBox.Show("Incorect address!");
                    return;
                }
            }

            // check on a unique

            List<academicDegree> all = new List<academicDegree>();
            all.AddRange(db.academicDegrees);

            all = all.FindAll
                (
                    delegate (academicDegree a)
                    { return a.degree.Equals(cbDegree.Text); }
                );

            if (all.Count == 0)
            {
                academicDegree a = new academicDegree();
                a.degree = cbDegree.Text;

                a = db.academicDegrees.Add(a);
                db.SaveChanges();

                dto.degree = a.degreeId;
            }
        }

        private void checkNewCountry()
        {
            if (!r.IsMatch(cbCountry.Text))
            {
                if (!cbCountry.Text.Contains(" "))
                {
                    if (cbCountry.Text.Length > 50)
                    {
                        MessageBox.Show("Incorect address!");
                        return;
                    }
                }
            }

            // check on a unique

            List<country> all = new List<country>();
            all.AddRange(db.countries);

            all = all.FindAll
                (
                    delegate (country c)
                    { return c.code.Equals(cbCountry.Text); }
                );

            if (all.Count == 0)
            {
                country c = new country();
                c.code = cbCountry.Text;

                c = countryCrud.create(c);

                dto.country = c.countryId;
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
