using Hatiku.Models;
using Hatiku.Models.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Repository
{
    public class PolicyRepository : BaseRepository, IPolicyRepository
    {
        public bool Add(Policy policy)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Policy> FetchAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Policy> FindByValue(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Policy> FindByValue(string value)
        {
            throw new NotImplementedException();
        }

        public int GetId(string policyName)
        {
            throw new NotImplementedException();
        }

        public int GetId(Policy policy)
        {
            throw new NotImplementedException();
        }
    }
}
