using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hatiku.Models;
using Hatiku.Models.IRepository;

namespace Hatiku.Repository
{
    public class RuleRepository : BaseRepository, IRuleRepository
    {
        public bool Add(Rule rule)
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

        public IEnumerable<Rule> FetchAll()
        {
            throw new NotImplementedException();
        }

        public Rule Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
