using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.Controllers
{
    class ParticipantController
    {
        DbAppContext db;

        public ParticipantController(DbAppContext db)
        {
            this.db = db;
        }


        public IQueryable<ViewConferencesWithParticipant>
            GetViewConference(int confId, IQueryable<ViewConferencesWithParticipant> participants)
        {
            IQueryable<ViewConferencesWithParticipant> viewConference;

            if (participants == null)
            {
                viewConference = db.ViewConferencesWithParticipants;
            }
            else
                viewConference = participants;

            // 0 - id мнимый элемент
            if (confId != 0)
                viewConference = viewConference.Where(p => p.conferenceId == confId);

            return viewConference;
        }

        public IQueryable<ViewConferencesWithParticipant>
            GetViewSubjects(int subjectId, IQueryable<ViewConferencesWithParticipant> participants)
        {
            IQueryable<ViewConferencesWithParticipant> viewSubjects;

            if (participants == null)
            {
                viewSubjects = db.ViewConferencesWithParticipants;
            }
            else
                viewSubjects = participants;

            // 0 - id мнимый элемент
            if (subjectId != 0)
                viewSubjects = viewSubjects.Where(p => p.subjectId == subjectId);

            return viewSubjects;
        }

        public IQueryable<ViewConferencesWithParticipant>
            GetViewThemes(int themeId, IQueryable<ViewConferencesWithParticipant> participants)
        {
            IQueryable<ViewConferencesWithParticipant> viewThemes;

            if (participants == null)
            {
                viewThemes = db.ViewConferencesWithParticipants;
            }
            else
                viewThemes = participants;

            // 0 - id мнимый элемент
            if (themeId != 0)
                viewThemes = viewThemes.Where(p => p.themeId == themeId);

            return viewThemes;
        }

        public IQueryable<ViewConferencesWithParticipant>
            GetViewDegrees(int degreeId, IQueryable<ViewConferencesWithParticipant> participants)
        {
            IQueryable<ViewConferencesWithParticipant> viewDegrees;

            if (participants == null)
            {
                viewDegrees = db.ViewConferencesWithParticipants;
            }
            else
                viewDegrees = participants;

            // 0 - id мнимый элемент
            if (degreeId != 0)
                viewDegrees = viewDegrees.Where(p => p.degreeId == degreeId);

            return viewDegrees;
        }

        public List<ViewConferencesWithParticipant> GetParticipants(ParticipantFilter filter)
        {
            IQueryable<ViewConferencesWithParticipant> participants = db.ViewConferencesWithParticipants;

            /*
             * 1) conference
             * 2) subject
             * 3) theme
             * 4) degree
             * */

            participants = GetViewConference(filter.conference, participants);
            participants = GetViewSubjects(filter.subject, participants);
            participants = GetViewThemes(filter.theme, participants);
            participants = GetViewDegrees(filter.degree, participants);
         
            return participants.ToList();
        }

    }
}    