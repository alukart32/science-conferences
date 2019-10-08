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

namespace ScienceConferenceApp.Forms.Crud
{
    public partial class ChooseScientistForm : BaseForm
    {
        CreateUpdateParticipantForm caller;
        DbAppContext db;

        public ChooseScientistForm()
        {
            InitializeComponent();
        }

        public ChooseScientistForm(CreateUpdateParticipantForm form, DbAppContext db)
        {
            caller = form;
            this.db = db;

            form.Hide();

            InitializeComponent();
        }

        private void ChooseScientistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.caller.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            caller.scientist = null;
            this.Close();
        }

        private void ChooseScientistForm_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void initData()
        {
            dataGridView1.DataSource = db.ViewScientists.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["scientistIdDataGridViewTextBoxColumn"].Value);
            
            // picking
            if (e.ColumnIndex == 6)
            {
                // Запрашиваем подтверждение
                string message = "Do you want to pick him?";
                string caption = "Y/n";
                var result = MessageBox.Show(message, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    caller.scientist = db.ViewScientists.SingleOrDefault(o => o.scientistId == id);
                    ViewScientist scientist = caller.scientist;

                    MessageBox.Show("Alright");
                    
                    caller.ScientistLabel.Text = scientist.firstName + " " + scientist.secondName + ","
                                                 + scientist.degree + "\n"
                                                 + scientist.companyName;

                    this.Close();
                }
            }
        }
    }
}
