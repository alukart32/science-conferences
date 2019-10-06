using ScienceConferenceApp.Forms.Crud;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.Model.DTO.Form
{
    abstract public class CUFormDTO<T>
    {
        public DbAppContext contex { get; set; }
        public CrudOpr op { get; set; }
        public T obj { get; set; }

        public CUFormDTO() { }

        public CUFormDTO(DbAppContext db, CrudOpr opr, T c)
        {
            this.contex = db;
            this.op = opr;
            this.obj = c;
        }
    }
}
