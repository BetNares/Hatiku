using Hatiku.Forms;
using Hatiku.Utils;
using Hatiku.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Presenters
{
    public class LoginPresenter
    {
        private ILoginForm _view;
        private string _connString;

        public LoginPresenter(ILoginForm view, string connectionString)
        {
            _view = view;
            _connString = connectionString;

            _view.Login += Login;

            ((Form)_view).Show();
        }

        private void Login(object sender, EventArgs e)
        {
            if (AccessControl.Login(_view.Username, _view.Password))
            {
                IAdminMainMenuView adminMainMenu = AdminMainMenu.GetMenu();
                _ = new AdminMainMenuPresenter(adminMainMenu, _connString);
                ((Form)_view).Hide();
            }
        }
    }
}
