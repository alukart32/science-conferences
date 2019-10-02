using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.Controllers
{
    class ConferenceCrud
    {

        DbAppContext db;

        public ConferenceCrud(DbAppContext db)
        {
            this.db = db;
        }

        public conference Create(string post, string fio)
        {
            // FirstOrDefault() выполнит запрос
            // возвратит первый найденный элемент коллекции.
            //conference c = db.conferences.Where().FirstOrDefault();

            //if (teach != null)
            //{
            //    return null; // вставка неудачна
            //}
            //else
            //{
            //    Teacher t = new Teacher();
            //    t.Post = post;
            //    t.PrepFIO = fio;
            //    db.Teachers.Add(t);
            //    db.SaveChanges();
            //    return t;
            //}
            return new conference();
        }

    }
}
