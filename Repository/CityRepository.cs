using Promobeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Promobeta.Repository
{
    public class CityRepository : ICity
    {
        private PromobetaContext DBcontext;

        public CityRepository(PromobetaContext objDataBase)
        {
            this.DBcontext = objDataBase;
        }
        public void Create(City state)
        {
            throw new NotImplementedException();
        }

        public void Delete(int cityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetCitiesByStateId(int stateId)
        {
            try
            {
                return DBcontext.City.Where(c => c.StateId.Equals(stateId)).ToList();

            } catch (Exception e)
            {
                return null;
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(City state)
        {
            throw new NotImplementedException();
        }
    }
}