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
            this.adminMainMenuView.ShowDiagnosisData += ShowDiagnosisDataView;

            ((Form)adminMainMenuView).Show();
        }

        private void ShowAdminPolicyView(object sender, EventArgs e)
        {
            IAdminPolicyView adminPolicyView = AdminAttachPolicy.GetMenu((AdminMainMenu)adminMainMenuView);
            IAdminPolicyRepository adminPolicyRepository = new AdminPolicyRepository(connectionString);
            _ = new AdminPolicyPresenter(adminPolicyRepository, adminPolicyView);
        }

        private void ShowPolicyView(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            IPolicyView policyView = AdminPolicyMenu.GetMenu((AdminMainMenu)adminMainMenuView);
            IPolicyRepository policyRepository = new PolicyRepository(connectionString);
            _ = new PolicyPresenter(policyView, policyRepository);
        }

        private void ShowAdminView(object sender, EventArgs e)
        {
            IAdminView adminView = AdminDataMenu.GetMenu((AdminMainMenu)adminMainMenuView);
            IAdminRepository adminRepository = new AdminRepository(connectionString);
            _ = new AdminPresenter(adminRepository, adminView);
        }

        private void ShowDiagnosisDataView(object sender, EventArgs e)
        {
            DiagnosisData diagnosisDataForm = DiagnosisData.GetMenu((AdminMainMenu)adminMainMenuView, connectionString);

            //IErrorHandlerView errorHandler = ErrorHandlerForm.GetMenu((AdminMainMenu)adminMainMenuView);

            //string msgTitle = "Tidak Ada Izin";
            //string msg = "Anda tidak memiliki izin untuk mengakses menu ini. " +
            //    "Hubungi Administrator Anda untuk meminta izin akses.";

            //_ = new ErrorHandlerFormPresenter(errorHandler, msgTitle, msg);
        }
    }
}
