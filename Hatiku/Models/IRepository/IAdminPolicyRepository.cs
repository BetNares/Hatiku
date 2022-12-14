using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models.IRepository
{
    public interface IAdminPolicyRepository
    {
        IEnumerable<AdminPolicy> FetchAll();
        IEnumerable<AdminPolicy> FindByValue(string value);
        bool Check(int userId, int policyId);
        bool Add(AdminPolicy admin);
        bool Delete(int userId, int policyId);
    }
}
