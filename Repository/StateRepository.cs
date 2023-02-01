using Promobeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Promobeta.Repository
{
    public class StateRepository : IState
    {
        private PromobetaContext DBcontext;

        public StateRepository (PromobetaContext objDataBase)
        {
            this.DBcontext = objDataBase;
        }

        public void Create(State state)
        {
            throw new NotImplementedException();
        }

        public void Delete(int stateId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<State> GetStates()
        {
            try
            {
                return DBcontext.State.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(State state)
        {
            throw new NotImplementedException();
        }
    }
}