using Promobeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Promobeta.Repository
{
    public class UnitPromotionsRepository : IUnitPromotions
    {
        PromobetaContext DBContext;

        public UnitPromotionsRepository(PromobetaContext objDataBase)
        {
            this.DBContext = objDataBase;
        }

        public void Create(UnitPromotions unitPromotions)
        {
            try
            {
                DBContext.UnitPromotions.Add(unitPromotions);
                DBContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<UnitPromotions> UnitPromotions(int companyUnitsId, string name)
        {
            try
            {
                if (String.IsNullOrEmpty(name))
                {
                    return DBContext.UnitPromotions.Where(p => p.CompanyUnitsId.Equals(companyUnitsId)).ToList();
                } else
                {
                    return DBContext.UnitPromotions.Where(p => p.CompanyUnitsId.Equals(companyUnitsId) && p.Name.ToLower().Contains(name.ToLower())).ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public UnitPromotions GetUnitPromotionsById(int unitPromotionsId)
        {
            throw new NotImplementedException();
        }

        public void Update(UnitPromotions unitPromotions)
        {
            throw new NotImplementedException();
        }

        public void Delete(int unitPromotionsId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}