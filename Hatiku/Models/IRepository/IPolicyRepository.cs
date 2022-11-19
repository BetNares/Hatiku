using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models.IRepository
{
    public interface IPolicyRepository
    {
        IEnumerable<Policy> FetchAll();
        IEnumerable<Policy> FindByValue(int id);
        IEnumerable<Policy> FindByValue(string value);
        int GetId(string policyName);
        int GetId(Policy policy);
        bool Add (Policy policy);
        bool Edit(int id);
        bool Delete(int id);
    }
}
