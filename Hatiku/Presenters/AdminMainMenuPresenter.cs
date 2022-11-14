using Hatiku.Forms;
using Hatiku.Models.IRepository;
using Hatiku.Repository;
using Hatiku.Views;
using Hatiku.Views.DataView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Presenters
{
    public class AdminMainMenuPresenter
    {
        IAdminMainMenuView adminMainMenuView;
        private string connectionString;

        public AdminMainMenuPresenter(IAdminMainMenuView adminMainMenuView, string connString)
        {
            this.adminMainMenuView = adminMainMenuView;
            connectionString = connString;

            this.adminMainMenuView.ShowAdminView += ShowAdminView;
            this.adminMainMenuView.ShowPolicyView += ShowPolicyView;
            this.adminMainMenuView.ShowAdminPolicyView += ShowAdminPolicyView;
            this.adminMainMenuView.ShowRuleView += ShowRuleView;
            this.adminMainMenuView.ShowRiskDiagnosisResult += ShowRiskDiagnosisResult;
            this.adminMainMenuView.ShowRiskDiagnosisHistory += ShowRiskDiagnosisHistory;
        }

        private void ShowRiskDiagnosisHistory(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowRiskDiagnosisResult(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowRuleView(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowAdminPolicyView(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //IAdminPolicyView adminPolicyView = <Nama Form buat admin-policy>.GetMenu((AdminMainMenu)adminMainMenuView);
            //IAdminPolicyRepository adminPolicyRepository = new AdminPolicyRepository(connectionString);
            //new AdminPolicyPresenter(policyRepository, policyView);
        }

        private void ShowPolicyView(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //IPolicyView policyView = <Nama Form buat policy>.GetMenu((AdminMainMenu)adminMainMenuView);
            //IPolicyRepository policyRepository = new PolicyRepository(connectionString);
            //new PolicyPresenter(policyRepository, policyView);
        }

        private void ShowAdminView(object sender, EventArgs e)
        {
            IAdminView adminView = AdminDataMenu.GetMenu((AdminMainMenu)adminMainMenuView);
            IAdminRepository adminRepository = new AdminRepository(connectionString);
            new AdminPresenter(adminRepository, adminView);
        }
    }
}
