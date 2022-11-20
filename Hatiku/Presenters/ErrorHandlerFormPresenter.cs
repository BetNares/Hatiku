using Hatiku.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Presenters
{
    public class ErrorHandlerFormPresenter
    {
        private IErrorHandlerView _view;

        public ErrorHandlerFormPresenter(IErrorHandlerView view, string msgTitle, string msg, Image img = null)
        {
            _view = view;

            _view.Message = msg;
            _view.MessageTitle = msgTitle;

            if (img != null)
                _view.InformationImage = img;
            
            ((Form)_view).Show();
        }
    } 
}
