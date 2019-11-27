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
    class CUParticipantFormDTO : CUFormDTO<ViewConferencesWithParticipant>
    {
        public CUParticipantFormDTO()
        {
        }

        public CUParticipantFormDTO(DbAppContext db, CrudOpr opr, ViewConferencesWithParticipant obj, UserDataDTO userData) : base(db, opr, obj, userData)
        {
        }
    }
}
