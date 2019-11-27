using ScienceConferenceApp.CRUD.Model.DTO.Form;
using ScienceConferenceApp.Forms.Crud;
using ScienceConferenceApp.Forms.DTO;
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
    public class CUConferenceFormDTO : CUFormDTO<conference>
    {
        public CUConferenceFormDTO()
        {
        }

        public CUConferenceFormDTO(DbAppContext db, CrudOpr opr, conference obj, UserDataDTO userData) : base(db, opr, obj, userData)
        {
        }
    }
}
