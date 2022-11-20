using Hatiku.Forms;
using Hatiku.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Presenters
{
    public class MainEntryPresenter
    {
        private IMainEntryView _view;
        private string _connString;

        public MainEntryPresenter(IMainEntryView view, string connString)
        {
            _view = view;
            _connString = connString;

            _view.ShowDoctorHome += ShowDoctorHome;
            _view.ShowAdminLogin += ShowAdminLogin;

            ((Form)_view).Show();

        }

        private void ShowAdminLogin(object sender, EventArgs e)
        {
            LogInForm loginForm = LogInForm.GetMenu();
            new LoginPresenter(loginForm, _connString);
            ((Form)_view).Hide();
        }

        private void ShowDoctorHome(object sender, EventArgs e)
        {
            DoctorHomeForm doctorHomeForm = DoctorHomeForm.GetMenu();
            new DoctorHomePresenter(doctorHomeForm, _connString);
            ((Form)_view).Hide();
        }
    }
}
