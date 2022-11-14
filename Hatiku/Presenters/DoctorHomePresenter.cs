using Hatiku.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Presenters
{
    public class DoctorHomePresenter
    {
        private IDoctorHomeView view;
        private string connString;

        public DoctorHomePresenter(IDoctorHomeView view, string connString)
        {
            this.view = view;
            this.connString = connString;

            this.view.ShowAboutForm += ShowAbout;
            this.view.ShowInputForm += ShowInput;

            ((Form)this.view).Show();
        }

        private void ShowInput(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowAbout(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
