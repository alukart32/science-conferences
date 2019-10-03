using ScienceConferenceApp.CRUD.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD
{
    class ParticipantCrud : Crud<participant>
    {
        public ParticipantCrud(DbAppContext db): base(db) { }

        public override participant create(participant obj)
        {
            throw new NotImplementedException();
        }

        public override bool delete(participant obj)
        {
            // Находим объект по этому ID
            participant p = db.participants.Find(obj.participantId);
            if (p != null)
            {
                // Удаляем объект из коллекции
                db.participants.Remove(p);
                db.SaveChanges(); // сохраняем в БД
                return true;
            }
            else return false;
        }

        public bool deleteBeforeConference(participant obj)
        {
            if (obj != null)
            {
                // Удаляем объект из коллекции
                db.participants.Remove(obj);
                db.SaveChanges(); // сохраняем в БД
                return true;
            }
            else return false;
        }

        public override bool update(participant obj)
        {
            throw new NotImplementedException();
        }
    }
}
