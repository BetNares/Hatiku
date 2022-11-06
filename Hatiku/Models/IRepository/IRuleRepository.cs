using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models.IRepository
{
    interface IRuleRepository
    {
        IEnumerable<Rule> FetchAll();
        Rule Find(int id);
        bool Add(Rule rule);
        bool Edit(int id);
        bool Delete(int id);
    }
}
