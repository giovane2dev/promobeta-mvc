using Promobeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promobeta.Repository
{
    interface ICompany
    {
        // CRUD tasks
        void Create(Company company);

        IEnumerable<Company> GetCompanies();

        Company GetCompanyById(int companyId);

        void Update(Company company);

        void Delete(int companyId);

        void Save();
    }
}
