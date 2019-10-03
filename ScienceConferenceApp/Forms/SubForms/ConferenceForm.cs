using ScienceConferenceApp.Controllers;
using ScienceConferenceApp.DataInitializer;
using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Forms.Crud;
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
    public partial class ConferenceForm : BaseForm
    {
        public ConferenceForm()
        {
            InitializeComponent();
            initData();
        }

        BaseForm caller;
        ConferenceController conferenceController;
        ConferenceFilter filter;

        ConferenceCrud conferenceCrud;


        DbAppContext db;


        public ConferenceForm(BaseForm form)
        {
            caller = form;
            form.Hide();
            InitializeComponent();
            initData();
        }

        private void initData()
        {
            db = new DbAppContext();
            conferenceController = new ConferenceController();
            filter = new ConferenceFilter();

            conferenceCrud = new ConferenceCrud(db);

            CheckBoxDataInit dataInit = new CheckBoxDataInit(db);

            dataInit.addConferences(cbConference);
            dataInit.addAddresses(cbAddress);
            dataInit.addCountries(cbCountry);

            dataGridView1.DataSource = db.ViewConferences.ToList();
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ViewConferences.ToList();

            cbConference.SelectedIndex = 0;
            cbAddress.SelectedIndex = 0;
            cbCountry.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conferenceController.GetConferences(filter);
        }

        private void cbConference_SelectedIndexChanged(object sender, EventArgs e)
        {
            conference c = (conference)cbConference.SelectedItem;
            filter.conference = c.conferenceId;
        }
        private void cbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            address a = (address)cbAddress.SelectedItem;
            filter.address = a.addressId;
        }
        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            country c = (country)cbCountry.SelectedItem;
            filter.country = c.countryId;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conferenceController.GetDate(dateTimePicker.Value);
            //filter.date = dateTimePicker.Value;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Здесь в кв. скобках используем значения свойства Name для столбцов
            conference c = new conference();

            c.conferenceId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["conferenceId"].Value);
            //c.conferenceName = dataGridView1.CurrentRow.Cells["Conference"].Value.ToString();
            //c.address = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            // Щелчок по кнопке Удалить (она 4-я, начиная с нуля)
            if (e.ColumnIndex == 6)
            {
                // Запрашиваем подтверждение
                string message = "Do you want to delete?";
                string caption = "Y/n";
                var result = MessageBox.Show(message, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // deleting
                    if (conferenceCrud.delete(c))
                    {
                        MessageBox.Show("Conference was deleted!");
                        dataGridView1.DataSource = db.ViewConferences.ToList();
                    }
                    else MessageBox.Show("Deleting was denied");
                }
            }
            //// Щелчок по кнопке Изменить
            //if (e.ColumnIndex == 3)
            //{
            //    using (TeacherForm frm = new TeacherForm(fio, post))
            //    {
            //        if (frm.ShowDialog() == DialogResult.OK)
            //        {
            //            // Находим объект по этому ID
            //            if (!b.UpdateTeacher(id, frm.tFIO.Text, frm.tPost.Text))
            //            {
            //                MessageBox.Show("Ошибка модификации. Возможно, строка не
            //                найдена!");
            //            };
            //            dgTeachers.Refresh();
            //        }
            //    }
            //}
        }

        private void AddConferenceButton_Click(object sender, EventArgs e)
        {
            AddConferenceForm f = new AddConferenceForm(this, db);
            f.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
