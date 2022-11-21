using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models.IRepository
{
    public interface IAdminRepository
    {
        IEnumerable<Admin> FetchAll();
        IEnumerable<Admin> FindByValue(string value);
        IEnumerable<Admin> FindByValue(int value);
        Admin? FindByUsername(string value);
        bool Login(string username, string password);
        bool Add(Admin admin);
        bool Edit(Admin admin);
        bool Delete(int id);
    }
}
