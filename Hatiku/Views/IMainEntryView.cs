using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Views
{
    public interface IMainEntryView
    {
        event EventHandler ShowAdminLogin;
        event EventHandler ShowDoctorHome;
    }
}
