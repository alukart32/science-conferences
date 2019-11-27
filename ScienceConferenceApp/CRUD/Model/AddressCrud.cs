using ScienceConferenceApp.CRUD.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD
{
    class AddressCrud: Crud<address>
    {
        public AddressCrud(DbAppContext db) : base(db) { }

        public override address create(address obj)
        {
            address a = db.addresses.Where(o => o.address1 == obj.address1 
            && o.country == obj.country).FirstOrDefault();
            if (a != null)
            {
                // obj is alredy existed
                return null;
            }
            else
            {
                address sa = db.addresses.Add(obj);
                db.SaveChanges();
                return sa;
            }
        }

        public override bool delete(address obj)
        {
            // Находим объект по этому ID
            address a = db.addresses.Find(obj.addressId);
            if (a != null)
            {
                // Удаляем объект из коллекции
                db.addresses.Remove(a);
                db.SaveChanges(); // сохраняем в БД
                return true;
            }
            else return false;
        }

        public override bool update(address obj)
        {
            // Find(id) выполнит запрос и найдет объект по этому ID
            address a = db.addresses.Find(obj.addressId);
            if (a != null)
            {
                address a1 = db.addresses.Where(o => o.address1 == obj.address1
                && o.country == obj.country).FirstOrDefault();
                if(a1 != null)
                {
                    return false;
                }

                a.address1 = obj.address1;
                a.country = obj.country;

                db.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
