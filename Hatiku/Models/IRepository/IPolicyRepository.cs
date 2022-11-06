using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models.IRepository
{
    interface IPolicyRepository
    {
        IEnumerable<Policy> FetchAll();
        Policy Find(int id);
        bool Add (Policy policy);
        bool Edit(int id);
        bool Delete(int id);
    }
}
