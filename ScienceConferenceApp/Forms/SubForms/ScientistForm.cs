using ScienceConferenceApp.Forms.Utils;
using ScienceConferenceApp.Model;
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
    public partial class ScientistForm : BaseForm
    {
        BaseForm caller;
        DbAppContext db;

        public ScientistForm()
        {
            InitializeComponent();
        }

        public ScientistForm(BaseForm caller, DbAppContext db)
        {
            this.caller = caller;
            this.db = db;
        }

        private void ScientistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
