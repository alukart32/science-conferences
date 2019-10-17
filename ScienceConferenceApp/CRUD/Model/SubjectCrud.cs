using ScienceConferenceApp.CRUD.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.Model
{
    class SubjectCrud : Crud<subject>
    {
        public SubjectCrud(DbAppContext db) : base(db)
        {
        }

        public override subject create(subject obj)
        {
            subject saved = db.subjects.Add(obj);
            db.SaveChanges();
            return saved;
        }

        public override bool delete(subject obj)
        {
            // Находим объект по этому ID
            subject s = db.subjects.Find(obj.subjectId);
            if (s != null)
            {
                // Удаляем объект из коллекции
                db.subjects.Remove(s);
                db.SaveChanges(); // сохраняем в БД
                return true;
            }
            else return false;
        }

        public override bool update(subject obj)
        {
            // Find(id) выполнит запрос и найдет объект по этому ID
            subject s = db.subjects.Find(obj.subjectId);
            if (s != null)
            {
                // get conference
                //conference c = (conference)db.conferences.Where(o => o.conferenceId == p.conference);
                s.subject1 = obj.subject1;

                db.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
