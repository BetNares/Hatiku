using Hatiku.Models;
using Hatiku.Models.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Utils
{
    public static class AccessControl
    {
        private static IAdminRepository _adminRepo;
        private static IAdminPolicyRepository _adminPolicyRepo;
        private static IPolicyRepository _policyRepo;
        private static Admin _currAdmin = null;
        private static List<string> _adminPermission;

        public static void Initialize(IAdminRepository adminRepo, IPolicyRepository policyRepo, IAdminPolicyRepository adminPolicyRepo)
        {
            _adminRepo = adminRepo;
            _adminPolicyRepo = adminPolicyRepo;
            _policyRepo = policyRepo;
        }

        public static bool CheckAuthorization(List<string> policyNames)
        {
            int adminId = _currAdmin.Id;
            List<int> policyIds =  new List<int>();
            foreach (var policyName in policyNames)
            {
                policyIds.Add(_policyRepo.GetId(policyName));
            }

            foreach (var id in policyIds)
            {
                if (_adminPolicyRepo.Check(adminId, id))
                    return true;
            }

            return false;
        }

        public static bool Login(string username, string password)
        {
            if (_adminRepo.Login(username, password))
            {
                SetCurrentAdmin(username);

                return true;
            }
            else
                return false;
        }

        private static void SetCurrentAdmin(string username)
        {
            _currAdmin = (Admin)_adminRepo.FindByValue(username);
        }
    }
}
