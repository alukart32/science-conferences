﻿using ScienceConferenceApp.CRUD.Utils;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.CRUD
{
    class ParticipantCrud : Crud<participant>
    {
        public ParticipantCrud(DbAppContext db): base(db) { }

        public override participant create(participant obj)
        {
            participant p = 
                db.participants.Where(o => o.participantId == obj.participantId).FirstOrDefault();

            if (p != null)
            {
                // obj is alredy existed
                return null;
            }
            else
            {
                scientist s = (scientist)db.scientists.Find(obj.scientist);

                obj.scientist1 = s;

                db.participants.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public override bool delete(participant obj)
        {
            // Находим объект по этому ID
            participant p = db.participants.Find(obj.participantId);
            if (p != null)
            {
                // Удаляем объект из коллекции
                db.participants.Remove(p);
                db.SaveChanges(); // сохраняем в БД
                return true;
            }
            else return false;
        }

        public bool deleteBeforeConference(participant obj)
        {
            if (obj != null)
            {
                // Удаляем объект из коллекции
                db.participants.Remove(obj);
                db.SaveChanges(); // сохраняем в БД
                return true;
            }
            else return false;
        }

        public override bool update(participant obj)
        {
            // Find(id) выполнит запрос и найдет объект по этому ID
            participant p = db.participants.Find(obj.participantId);
            if (p != null)
            {
                // get conference
                //conference c = (conference)db.conferences.Where(o => o.conferenceId == p.conference);
                p.conference = obj.conference;
                p.subject = obj.subject;
                p.theme = obj.theme;
                p.publication = obj.publication;
                    
                db.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
