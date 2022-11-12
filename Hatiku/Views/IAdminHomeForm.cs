using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Views
{
    public interface IAdminHomeForm
    {
        event EventHandler ShowAdminManagementMenu;
        event EventHandler ShowExpertSystemManagementMenu;
        event EventHandler ShowMachineLearningManagementMenu;
    }
}
