using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.Controllers
{
    class ScientistController
    {
        DbAppContext db;

        public ScientistController(DbAppContext db)
        {
            this.db = db;
        }

        public IQueryable<ViewScientist>
            GetViewScientistCountry(int countryId, IQueryable<ViewScientist> scientists)
        {
            IQueryable<ViewScientist> viewCountry;

            if (scientists == null)
            {
                viewCountry = db.ViewScientists;
            }
            else
                viewCountry = scientists;

            // 0 - id мнимый элемент
            if (countryId != 0)
                viewCountry = viewCountry.Where(o => o.countryId == countryId);

            return viewCountry;
        }

        private IQueryable<ViewScientist> GetViewScientistCompany(int companyId, IQueryable<ViewScientist> scientists)
        {
            IQueryable<ViewScientist> viewCompanies;

            if (scientists == null)
            {
                viewCompanies = db.ViewScientists;
            }
            else
                viewCompanies = scientists;

            // 0 - id мнимый элемент
            if (companyId != 0)
                viewCompanies = viewCompanies.Where(o => o.companyId == companyId);

            return viewCompanies;
        }

        private IQueryable<ViewScientist> GetViewScientistDegree(int degreeId, IQueryable<ViewScientist> scientists)
        {
            IQueryable<ViewScientist> viewDegrees;

            if (scientists == null)
            {
                viewDegrees = db.ViewScientists;
            }
            else
                viewDegrees = scientists;

            // 0 - id мнимый элемент
            if (degreeId != 0)
                viewDegrees = viewDegrees.Where(o => o.degreeId == degreeId);

            return viewDegrees;
        }

        public List<ViewScientist> GetScientists(ScientistFilter filter)
        {
            IQueryable<ViewScientist> scientists = db.ViewScientists;

            /*
             * 1) company
             * 2) country
             * 4) degree
             * */

            scientists = GetViewScientistCountry(filter.country, scientists);
            scientists = GetViewScientistCompany(filter.company, scientists);
            scientists = GetViewScientistDegree(filter.degree, scientists);

            return scientists.ToList();
        }
    }
}
