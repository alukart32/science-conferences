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
    public partial class ConferenceForm : BaseForm
    {
        public ConferenceForm()
        {
            InitializeComponent();
        }

        BaseForm caller;
        public ConferenceForm(BaseForm form)
        {
            caller = form;
            form.Hide();
            InitializeComponent();
        }

        private void ConferenceForm_Load(object sender, EventArgs e)
        {

        }

        private void ConferenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
