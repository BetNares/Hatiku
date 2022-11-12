using Hatiku.Models;
using Hatiku.Models.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Repository
{
    public class AdminPolicyRepository : BaseRepository, IAdminPolicyRepository
    {

        public bool Add(AdminPolicy admin)
        {
            throw new NotImplementedException();
        }

        public bool Check(int userId, int policyId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int userId, int policyId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdminPolicy> FetchAll()
        {
            throw new NotImplementedException();
        }
    }
}
