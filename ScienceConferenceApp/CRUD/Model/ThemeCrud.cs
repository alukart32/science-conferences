using ScienceConferenceApp.CRUD.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.Model
{
    class ThemeCrud : Crud<theme>
    {
        public ThemeCrud(DbAppContext db) : base(db) { }

        public override theme create(theme obj)
        {
            theme t = db.themes.Where(o => o.themeName== obj.themeName).FirstOrDefault();
            if (t != null)
            {
                // obj is alredy existed
                return null;
            }
            else
            {
                theme tt = new theme();
                tt.themeName = obj.themeName;

                theme ttt = db.themes.Add(tt);
                db.SaveChanges();
                return ttt;
            }
        }

        public override bool delete(theme obj)
        {
            // Находим объект по этому ID
            theme t = db.themes.Find(obj.themeId);
            if (t != null)
            {
                // Удаляем объект из коллекции
                db.themes.Remove(t);
                db.SaveChanges(); // сохраняем в БД
                return true;
            }
            else return false;
        }

        public override bool update(theme obj)
        {
            // Find(id) выполнит запрос и найдет объект по этому ID
            theme t = db.themes.Find(obj.themeId);
            if (t != null)
            {
                theme t1 = db.themes.Where(o => o.themeName == obj.themeName).FirstOrDefault();
                if( t1 != null)
                {
                    // obj is alredy existed
                    return false;
                }

                t.themeName = obj.themeName;
                db.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
