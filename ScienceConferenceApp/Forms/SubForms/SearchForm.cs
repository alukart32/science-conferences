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
    public partial class SearchForm : BaseForm
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        BaseForm caller;

        public SearchForm(BaseForm form)
        {
            caller = form;
            form.Hide();
            InitializeComponent();
        }


        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
