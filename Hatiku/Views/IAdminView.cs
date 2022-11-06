using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Views.EventView;


namespace Hatiku.Views
{
    public interface IAdminView: IEventView, IUpdateEventView
    {
        int UserId { get; set; }
        string Username { get; set; }
        string Password { get; set; }


        void SetAdminListBinding(BindingSource adminList);
    }
}
