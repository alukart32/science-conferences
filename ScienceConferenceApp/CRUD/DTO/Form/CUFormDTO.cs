using ScienceConferenceApp.Forms.Crud;
using ScienceConferenceApp.Forms.DTO;
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
        public UserDataDTO userData { get; set; }

        public CUFormDTO() { }

        public CUFormDTO(DbAppContext db, CrudOpr opr, T obj, UserDataDTO userData)
        {
            this.contex = db;
            this.op = opr;
            this.obj = obj;
            this.userData = userData;
        }
    }
}
