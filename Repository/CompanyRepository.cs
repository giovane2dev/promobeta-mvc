using Promobeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Promobeta.Repository
{
    public class CompanyRepository : ICompany
    {
        private PromobetaContext DBcontext;

        public CompanyRepository(PromobetaContext objDataBase)
        {
            this.DBcontext = objDataBase;
        }

        public void Create(Company company)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public Company GetCompanyById(int companyId)
        {
            try
            {
                return DBcontext.Company.Find(companyId);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void Update(Company company)
        {
            throw new NotImplementedException();
        }

        public void Delete(int companyId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}