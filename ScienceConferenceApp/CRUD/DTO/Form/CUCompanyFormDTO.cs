using ScienceConferenceApp.CRUD.Model.DTO.Form;
using ScienceConferenceApp.Forms.Crud;
using ScienceConferenceApp.Forms.DTO;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.DTO.Form
{
    public class CUCompanyFormDTO : CUFormDTO<ViewCompany>
    {
        public CUCompanyFormDTO()
        {
        }

        public CUCompanyFormDTO(DbAppContext db, CrudOpr opr, ViewCompany obj, UserDataDTO userData) : base(db, opr, obj, userData)
        {
        }
    }
}
