using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Views
{
    public interface IAdminView: IView
    {
        int UserId { get; set; }
        string Username { get; set; }
        string Password { get; set; }

        void SetAdminListBinding(BindingSource adminList);
        void Show();
    }
}
