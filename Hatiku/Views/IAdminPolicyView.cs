using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hatiku.Views.EventView;

namespace Hatiku.Views
{
    public interface IAdminPolicyView: IEventView
    {
        int UserId { get; set; }
        int PolicyId { get; set; }


    }
}
