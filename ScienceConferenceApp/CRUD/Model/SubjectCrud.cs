﻿using ScienceConferenceApp.CRUD.Utils;
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
            subject c = db.subjects.Where(o => o.subject1 == obj.subject1).FirstOrDefault();
            if (c != null)
            {
                return null;
            }
            else
            {
                subject saved = db.subjects.Add(obj);
                db.SaveChanges();
                return saved;
            }
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
                subject s1 = db.subjects.Where(o => o.subject1 == obj.subject1).FirstOrDefault();
                if(s1 != null)
                {
                    return false;
                }

                s.subject1 = obj.subject1;

                db.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
