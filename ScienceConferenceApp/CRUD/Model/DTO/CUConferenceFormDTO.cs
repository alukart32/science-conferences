using ScienceConferenceApp.Forms.Crud;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.Model.DTO
{
    /*
     * DTO class for CreateUpdateConferenceForm
     * 
     */
    public class CUConferenceFormDTO
    {
        public DbAppContext contex { get; set; }
        public CrudOpr op { get; set; }
        public conference obj { get; set; }

        public CUConferenceFormDTO() { }

        public CUConferenceFormDTO(DbAppContext db, CrudOpr opr, conference c)
        {
            this.contex = db;
            this.op = opr;
            this.obj = c;
        }
    }
}
