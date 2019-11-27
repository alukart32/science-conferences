using ScienceConferenceApp.CRUD.DTO;
using ScienceConferenceApp.CRUD.DTO.Form;
using ScienceConferenceApp.CRUD.Model;
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
    public partial class CreateUpdateCompanyForm : BaseForm
    {
        CUCompanyFormDTO dto;
        BaseForm caller;
        Regex r = new Regex("^[a-zA-Z]*$");

        CompanyDTO companyDTO;

        CompanyCrud crud;

        public CreateUpdateCompanyForm()
        {
            InitializeComponent();
        }

        public CreateUpdateCompanyForm(BaseForm caller, CUCompanyFormDTO dto)
        {
            this.dto = dto;
            this.caller = caller;

            this.companyDTO = new CompanyDTO();
            this.crud = new CompanyCrud(dto.contex);

            InitializeComponent();
        }

        private void CreateUpdateCompanyForm_Load(object sender, EventArgs e)
        {
            if(dto.op == CrudOpr.Update)
            {
                cbCountry.Text = dto.obj.code;
                CompanyName.Text = dto.obj.companyName;

                companyDTO.country = dto.obj.countryId;
                companyDTO.name = dto.obj.companyName;
                companyDTO.id = dto.obj.companyId;
            }

            cbCountry.DataSource = dto.contex.countries.ToList();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            checkData();

            company c = new company();
   
            c.companyName = companyDTO.name;
            c.country = companyDTO.country;

            if (dto.op == CrudOpr.Update)
            {
                c.companyId = companyDTO.id;
                if (crud.update(c))
                {
                    MessageBox.Show("Company was updated!");
                    this.Close();
                }
                else
                    MessageBox.Show("Company wasn't updated!");
            }
            else
               if (crud.create(c) != null)
            {
                MessageBox.Show("Company was added!");
                this.Close();
            }
            else
                MessageBox.Show("Company wasn't added!");
        }

        // checking all data for conference
        private void checkData()
        {
            // check name
            if (r.IsMatch(CompanyName.Text))
                companyDTO.name = CompanyName.Text;
            else
            {
                if (CompanyName.Text.Contains(" "))
                    companyDTO.name = CompanyName.Text;
                else
                {
                    if (dto.op != CrudOpr.Update)
                        CompanyName.Text = "";
                    else
                        CompanyName.Text = companyDTO.name;

                    MessageBox.Show("Incorrect conference name!");
                    return;
                }
            }

            if(cbCountry.Text == "")
                MessageBox.Show("Country wasn't choosen!");
            
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            country c = (country)cbCountry.SelectedItem;
            companyDTO.country = c.countryId;
        }
    }
}
