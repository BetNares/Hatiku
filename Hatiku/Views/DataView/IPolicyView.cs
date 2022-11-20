using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Views.EventView;

namespace Hatiku.Views.DataView
{
    public interface IPolicyView: IEventView, IUpdateEventView, IShowView
    {
        int PolicyId { get; set; }
        string PolicyName { get; set; }
        string Detail{ get; set; }

        void SetPolicyListBinding(BindingSource policyList);
    }
}
