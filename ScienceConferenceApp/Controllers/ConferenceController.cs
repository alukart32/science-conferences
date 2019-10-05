using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.Controllers
{
    class ConferenceController
    {
        DbAppContext db;

        public ConferenceController()
        {
            db = new DbAppContext();

        }

        public IQueryable<ViewConference> 
            GetViewConferences(int conferenceId, IQueryable<ViewConference> conferences)
        {
            IQueryable<ViewConference> viewConferences;

            if (conferences == null)
            {
                viewConferences = db.ViewConferences;
            }
            else
                viewConferences = conferences;

            // 0 - id мнимый элемент
            if (conferenceId != 0)       
              viewConferences = viewConferences.Where(c => c.conferenceId == conferenceId);

            return viewConferences;
        }

        public IQueryable<ViewConference>
            GetAddresses(int addressId, IQueryable<ViewConference> conferences)
        {
            IQueryable<ViewConference> viewAddresses;
        
            if (conferences == null)
            {
                viewAddresses = db.ViewConferences;
            }
            else
                viewAddresses = conferences;

            // 0 - id мнимый элемент
            if (addressId != 0)
                viewAddresses = viewAddresses.Where(a => a.addressId == addressId);

            return viewAddresses;
        }

        public IQueryable<ViewConference>
            GetCountry(int countryId, IQueryable<ViewConference> conferences)
        {
            IQueryable<ViewConference> viewCountries;

            if (conferences == null)
            {
                viewCountries = db.ViewConferences;
            }
            else
                viewCountries = conferences;

            // 0 - id мнимый элемент
            if (countryId != 0)
                viewCountries = viewCountries.Where(c => c.countryId == countryId);

            return viewCountries;
        }

        public List<ViewConference>
            GetDate(DateTime date)
        {
            IQueryable<ViewConference> viewCountries;

            viewCountries = db.ViewConferences;

            viewCountries = viewCountries.Where(c => c.date == date);

            return viewCountries.ToList();
        }

        public IQueryable<ViewConference>
           GetDate(DateTime date, IQueryable<ViewConference> conferences)
        {
            IQueryable<ViewConference> viewCountries;

            //if (date == DateTime.MinValue)
            //    return conferences;

            if (conferences == null)
            {
                viewCountries = db.ViewConferences;
            }
            else
                viewCountries = conferences;

            viewCountries = viewCountries.Where(c => c.date == date);

            return viewCountries;
        }

        public List<ViewConference> GetConferences(ConferenceFilter filter)
        {
            IQueryable<ViewConference> conf = db.ViewConferences;

            /*
             * 1) conference
             * 2) subject
             * 3) theme
             *
             * */

            conf = GetViewConferences(filter.conference, conf);
            conf = GetCountry(filter.country, conf);
            conf = GetAddresses(filter.address, conf);

            if (filter.withDate)
            {
                conf = GetDate(filter.date.Date, conf);
            }

            return conf.ToList();
        }
    }
}
