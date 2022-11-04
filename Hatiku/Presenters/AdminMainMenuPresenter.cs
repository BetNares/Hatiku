using Hatiku.Forms;
using Hatiku.Models.IRepository;
using Hatiku.Repository;
using Hatiku.Views;
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
        }

        private void ShowAdminView(object sender, EventArgs e)
        {
            IAdminView adminView = AdminDataMenu.GetMenu((AdminMainMenu)adminMainMenuView);
            IAdminRepository adminRepository = new AdminRepository(connectionString);
            new AdminPresenter(adminRepository, adminView);
        }
    }
}
