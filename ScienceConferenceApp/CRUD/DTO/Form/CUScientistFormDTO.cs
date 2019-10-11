using ScienceConferenceApp.CRUD.Model.DTO.Form;
using ScienceConferenceApp.Forms.Crud;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.DTO.Form
{
    class CUScientistFormDTO : CUFormDTO<ViewScientist>
    {
        public CUScientistFormDTO()
        {
        }

        public CUScientistFormDTO(DbAppContext db, CrudOpr opr, ViewScientist obj) : base(db, opr, obj)
        {
        }
    }
}
