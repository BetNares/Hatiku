using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Views.EventView;


namespace Hatiku.Views.DataView
{
    public interface IAdminView: IEventView, IUpdateEventView, IShowView
    {
        int UserId { get; set; }
        string Username { get; set; }
        string Password { get; set; }


        void SetAdminListBinding(BindingSource adminList);
    }
}
