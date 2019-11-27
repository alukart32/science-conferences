using ScienceConferenceApp.Filter;
using ScienceConferenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferenceApp.Controllers
{
    class CompanyController
    {
        DbAppContext db;

        public CompanyController(DbAppContext db)
        {
            this.db = db;
        }

        public IQueryable<ViewCompany>
          GetByCountry(int country, IQueryable<ViewCompany> companies)
        {
            IQueryable<ViewCompany> viewCompanies;

            if (companies == null)
            {
                viewCompanies = db.ViewCompanies;
            }
            else
                viewCompanies = companies;

            if(country != 0)
                viewCompanies = viewCompanies.Where(c => c.country == country);

            return viewCompanies;
        }

        public List<ViewCompany> GetCompanies(CompanyFilter filter)
        {
            IQueryable<ViewCompany> comp = db.ViewCompanies;

            comp = GetByCountry(filter.countryId, comp);

            return comp.ToList();
        }
    }
}
