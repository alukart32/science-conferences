using ScienceConferenceApp.CRUD.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD
{
    /*
     * Crud operations for country object.
     * 
     */
    class CountryCrud : Crud<country>
    {
        public CountryCrud(DbAppContext db) : base(db) { }

        public override country create(country obj)
        {         
            country c = db.countries.Where(o => o.code == obj.code).FirstOrDefault();
            if (c != null)
            {
                // obj is alredy existed
                return null; 
            }
            else
            {
                country newCountry = new country();
                newCountry.code = obj.code;

                c = db.countries.Add(newCountry);
                db.SaveChanges();
                return c;
            }
        }

        public override bool delete(country obj)
        {
            // Находим объект по этому ID
            country c = db.countries.Find(obj.countryId);
            if (c != null)
            {
                // Удаляем объект из коллекции
                db.countries.Remove(c);
                db.SaveChanges(); // сохраняем в БД
                return true;
            }
            else return false;
        }

        public override bool update(country obj)
        {
            // Find(id) выполнит запрос и найдет объект по этому ID
            country c = db.countries.Find(obj.countryId);
            if (c != null)
            {
                c.code = obj.code;
                db.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
