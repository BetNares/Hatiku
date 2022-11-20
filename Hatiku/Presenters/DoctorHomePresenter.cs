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
    public class DoctorHomePresenter
    {
        private IDoctorHomeView _view;
        private string connString;

        public DoctorHomePresenter(IDoctorHomeView view, string connString)
        {
            this._view = view;
            this.connString = connString;

            this._view.ShowAboutForm += ShowAbout;
            this._view.ShowInputForm += ShowInputForm;

            ((Form)this._view).Show();
        }

        private void ShowInputForm(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //var inputForm = new InputForm();
            //((Form)_view).Close();
            //inputForm.Show();
        }

        private void ShowAbout(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            ((Form)_view).Close();
            aboutForm.Show();
            
        }
    }
}
