using ScienceConferenceApp.CRUD.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.Model
{
    class ScientistCrud : Crud<scientist>
    {
        public ScientistCrud(DbAppContext db) : base(db)
        {
        }

        public override scientist create(scientist obj)
        {
            db.scientists.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public override bool delete(scientist obj)
        {
            // Находим объект по этому ID
            scientist s = db.scientists.Find(obj.scientistId);
            if (s != null)
            {
                // Удаляем объект из коллекции
                db.scientists.Remove(s);
                db.SaveChanges(); // сохраняем в БД
                return true;
            }
            else return false;
        }

        public override bool update(scientist obj)
        {
            // Find(id) выполнит запрос и найдет объект по этому ID
            scientist s = db.scientists.Find(obj.scientistId);
            if (s != null)
            {
                // get conference
                //conference c = (conference)db.conferences.Where(o => o.conferenceId == p.conference);
                s.firstName = obj.firstName;
                s.secondName = obj.secondName;
                s.academicDegree = obj.academicDegree;
                s.company = obj.company;
                s.country = obj.country;
               
                db.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
