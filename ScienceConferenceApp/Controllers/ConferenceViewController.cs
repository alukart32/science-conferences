using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.Controllers
{
    class ConferenceViewController
    {
        DbAppContext db;

        public ConferenceViewController()
        {
            db = new DbAppContext();

        }

        public IQueryable<ViewConferencesWithParticipant> 
            GetViewConferences(int conferenceId, IQueryable<ViewConferencesWithParticipant> conferences)
        {
            IQueryable<ViewConferencesWithParticipant> viewConferences;

            if (conferences == null)
            {
                viewConferences =db.ViewConferencesWithParticipants;
            }
            else
                viewConferences = conferences;

           
            if(conferenceId != 2)
                viewConferences = viewConferences.Where(c => c.conferenceId == conferenceId);

            return viewConferences;
        }

        public IQueryable<ViewConferencesWithParticipant>
            GetViewSubject(int subjectId, IQueryable<ViewConferencesWithParticipant> conferences)
        {
            IQueryable<ViewConferencesWithParticipant> viewSubjects;

            if (conferences == null)
            {
                viewSubjects = db.ViewConferencesWithParticipants;
            }
            else
                viewSubjects = conferences;

            if (subjectId != 1)
                viewSubjects = viewSubjects.Where(c => c.subjectId == subjectId);

            return viewSubjects;
        }

        public IQueryable<ViewConferencesWithParticipant>
            GetViewTheme(int themeId, IQueryable<ViewConferencesWithParticipant> conferences)
        {
            IQueryable<ViewConferencesWithParticipant> viewThemes;

            if (conferences == null)
            {
                viewThemes = db.ViewConferencesWithParticipants;
            }
            else
                viewThemes = conferences;

            if (themeId != 1)
                viewThemes = viewThemes.Where(c => c.themeId == themeId);

            return viewThemes;
        }

        public List<ViewConferencesWithParticipant> GetConferences(ConferenceFilter filter)
        {
            IQueryable<ViewConferencesWithParticipant> conf = db.ViewConferencesWithParticipants;

            /*
             * 1) conference
             * 2) subject
             * 3) theme
             *
             * */

            conf = GetViewConferences(filter.conference, conf);
            conf = GetViewSubject(filter.subject, conf);
            conf = GetViewTheme(filter.theme, conf);

            return conf.ToList();
        }
    }
}
