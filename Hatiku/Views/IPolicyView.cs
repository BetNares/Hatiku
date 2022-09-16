using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Views
{
    public interface IPolicyView: IView
    {
        int PolicyId { get; set; }
        string Name { get; set; }
        string Detail{ get; set; }

        void SetPolicyListBinding(BindingSource policyList);
        void Show();
    }
}
