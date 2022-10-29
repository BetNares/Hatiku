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
        public string MlApiId { get; set; }
        public string MlApiEndpoint { get; set; }
        public string MlApiKey { get; set; }
        public bool IsConnect { get; set; }

        Task InvokeRequestResponseService(string scoreRequestContent);
        void SetAdminListBinding(BindingSource adminList);
        void Show();
    }
}
