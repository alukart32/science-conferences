using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD.Utils
{
    abstract class Crud<T>
    {
        public DbAppContext db;

        public Crud(DbAppContext db)
        {
            this.db = db;
        }

        public abstract T create(T obj);
        public abstract bool update(T obj);
        public abstract bool delete(T obj);
    }
}
