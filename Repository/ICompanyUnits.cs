using Promobeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promobeta.Repository
{
    interface ICompanyUnits
    {
        // CRUD tasks

        void Create(CompanyUnits companyUnits);

        IEnumerable<CompanyUnits> GetCompanyUnits(int companyId, string name = "");

        CompanyUnits GetCompanyUnitsById(int companyUnitsId);

        void Update(CompanyUnits companyUnits);

        void Delete(int companyUnitsId);

        void Save();
    }
}
