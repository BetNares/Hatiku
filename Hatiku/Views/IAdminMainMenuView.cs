using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Views
{
    public interface IAdminMainMenuView
    {
        event EventHandler ShowAdminView;
        event EventHandler ShowPolicyView;
        event EventHandler ShowAdminPolicyView;
        event EventHandler ShowDiagnosisData;
    }
}
