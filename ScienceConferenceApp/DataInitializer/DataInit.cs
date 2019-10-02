using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceConferenceApp.DataInitializer
{  
    class DataInit
    {
        protected DbAppContext db;
        List<ComboBox> comboBoxes;

        public DataInit(DbAppContext db)
        {
            this.db = db;
        }

        public DataInit(DbAppContext db, List<ComboBox> comboBoxes)
        {
            this.db = db;
            this.comboBoxes = comboBoxes;
        }
    }
}
