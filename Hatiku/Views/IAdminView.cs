using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Views
{
    public interface IAdminView
    {
        int UserId { get; set; }
        string Username { get; set; }
        string Password { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetAdminListBinding(BindingSource adminList);
        void Show();
    }
}
