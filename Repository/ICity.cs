using Promobeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promobeta.Repository
{
    interface ICity
    {
        void Create(City state);
        IEnumerable<City> GetCitiesByStateId(int stateId);
        void Update(City state);
        void Delete(int cityId);
        void Save();
    }
}
