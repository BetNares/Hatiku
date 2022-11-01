using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Views
{
    public interface IMlApiView
    {
        string MlApiId { get; set; }
        string MlApiEndpoint { get; set; }
        string MlApiKey { get; set; }
        bool IsConnect { get; set; }

        Task InvokeRequestResponseService(string scoreRequestContent);
        void SetAdminListBinding(BindingSource adminList);
        void Show();
    }
}
