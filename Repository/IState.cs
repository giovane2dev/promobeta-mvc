using Promobeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promobeta.Repository
{
    interface IState
    {
        void Create(State state);
        IEnumerable<State> GetStates();
        void Update(State state);
        void Delete(int stateId);
        void Save();
    }
}
