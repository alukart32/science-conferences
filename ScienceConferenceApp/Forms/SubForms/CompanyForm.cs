using ScienceConferenceApp.Forms.Utils;
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
    public partial class CompanyForm : BaseForm
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        BaseForm caller;
        public CompanyForm(BaseForm form)
        {
            caller = form;
            form.Hide();
            InitializeComponent();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {

        }

        private void CompanyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
