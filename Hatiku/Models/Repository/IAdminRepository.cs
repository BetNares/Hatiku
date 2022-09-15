using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models.Repository
{
    public interface IAdminRepository
    {
        IEnumerable<Admin> FetchAll();
        IEnumerable<Admin> Find(int id);
        bool Add(Admin admin);
        bool Edit(Admin admin);
        bool Delete(int id);
    }
}
