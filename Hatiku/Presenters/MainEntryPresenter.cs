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
        private IMainEntryView view;
        private string connString;

        public MainEntryPresenter(IMainEntryView view, string connString)
        {
            this.view = view;
            this.connString = connString;

            this.view.ShowDoctorHome += ShowDoctorHome;
            this.view.ShowAdminLogin += ShowAdminLogin;

            ((Form)this.view).Show();

        }

        private void ShowAdminLogin(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowDoctorHome(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
