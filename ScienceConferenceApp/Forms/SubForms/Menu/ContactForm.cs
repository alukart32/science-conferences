using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceConferenceApp.Forms.Utils.Menu
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private BaseForm caller;

        public ContactForm(BaseForm form)
        {
            caller = form;
            //form.Hide();
            InitializeComponent();
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {

        }

        private void ContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
