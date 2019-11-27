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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private BaseForm caller;

        public HelpForm(BaseForm form)
        {
            caller = form;
            //form.Hide();
            InitializeComponent();
        }


        private void HelpForm_Load(object sender, EventArgs e)
        {

        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
