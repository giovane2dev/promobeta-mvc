using Promobeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promobeta.Repository
{
    interface IUnitPromotions
    {
        // CRUD tasks

        void Create(UnitPromotions unitPromotions);

        IEnumerable<UnitPromotions> UnitPromotions(int companyUnitsId, string name);

        UnitPromotions GetUnitPromotionsById(int unitPromotionsId);

        void Update(UnitPromotions unitPromotions);

        void Delete(int unitPromotionsId);

        void Save();
    }
}
