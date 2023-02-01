using Promobeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Promobeta.Repository
{
    public class CompanyUnitsRepository : ICompanyUnits
    {
        private PromobetaContext DBcontext;

        public CompanyUnitsRepository(PromobetaContext objDataBase)
        {
            this.DBcontext = objDataBase;
        }

        public void Create(CompanyUnits companyUnits)
        {
            try
            {
                DBcontext.CompanyUnits.Add(companyUnits);
                DBcontext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<CompanyUnits> GetCompanyUnits(int companyId, string name = "")
        {
            try
            {
                if (String.IsNullOrEmpty(name))
                {
                    return DBcontext.CompanyUnits.Where(u => u.CompanyId.Equals(companyId)).ToList();
                } else
                {
                    return DBcontext.CompanyUnits.Where(u => u.CompanyId.Equals(companyId) && u.Name.ToLower().Contains(name.ToLower())).ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public CompanyUnits GetCompanyUnitsById(int companyUnitsId)
        {
            throw new NotImplementedException();
        }

        public void Update(CompanyUnits companyUnits)
        {
            throw new NotImplementedException();
        }

        public void Delete(int companyUnitsId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}