using ScienceConferenceApp.CRUD;
using ScienceConferenceApp.CRUD.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.Controllers
{
    class ConferenceCrud: Crud<conference>
    {

        ParticipantCrud participantCrud;

        public ConferenceCrud(DbAppContext db): base(db){
            participantCrud = new ParticipantCrud(db);
        }

        public override conference create(conference obj)
        {
            conference c = db.conferences.Where(o => o.conferenceId == obj.conferenceId).FirstOrDefault();
            if (c != null)
            {
                // obj is alredy existed
                return null;
            }
            else
            {
                db.conferences.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public override bool delete(conference obj)
        {
            // Находим объект по этому ID
            conference c = db.conferences.Find(obj.conferenceId);
            
            if (c != null)
            {
                participant p = db.participants.Where(o => o.conference == obj.conferenceId).FirstOrDefault();

                if (p != null)
                {
                    participantCrud.deleteBeforeConference(p);
                }
                

                // Удаляем объект из коллекции
                db.conferences.Remove(c);
                db.SaveChanges(); // сохраняем в БД
                return true;
            }
            else return false;
        }

        public override bool update(conference obj)
        {
            // Find(id) выполнит запрос и найдет объект по этому ID
            conference c = db.conferences.Find(obj.conferenceId);
            if (c != null)
            {
                c.address = obj.address;
                c.conferenceName = obj.conferenceName;
                c.date = obj.date;
                
                db.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
