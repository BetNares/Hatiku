using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Views.EventView;

namespace Hatiku.Views.DataView
{
    public interface IAdminPolicyView: IEventView, IShowView
    {
        int UserId { get; set; }
        int PolicyId { get; set; }

        void SetAdminPolicyBinding(BindingSource adminPolicyBinding);
    }
}