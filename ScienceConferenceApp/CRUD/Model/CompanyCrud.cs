using ScienceConferenceApp.CRUD.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.Model
{
    public class CompanyCrud : Crud<company>
    {
        public CompanyCrud(DbAppContext db) : base(db)
        {
        }

        public override company create(company obj)
        {
            company c= db.companies.Add(obj);
            db.SaveChanges();
            return c;
        }

        public override bool delete(company obj)
        {
            // Находим объект по этому ID
            company c = db.companies.Find(obj.companyId);

            if (c != null)
            {
               
                // Удаляем объект из коллекции
                db.companies.Remove(c);
                db.SaveChanges(); // сохраняем в БД
                return true;
            }
            else return false;
        }

        public override bool update(company obj)
        {
            company c = db.companies.Find(obj.companyId);
            if (c != null)
            {
                c.companyName = obj.companyName;
                c.country = obj.country;

                db.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
