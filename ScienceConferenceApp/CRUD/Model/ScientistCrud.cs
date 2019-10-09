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
            throw new NotImplementedException();
        }

        public override bool delete(scientist obj)
        {
            throw new NotImplementedException();
        }

        public override bool update(scientist obj)
        {
            throw new NotImplementedException();
        }
    }
}
