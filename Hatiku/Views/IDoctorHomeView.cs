using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Views
{
    public interface IDoctorHomeView
    {
        event EventHandler ShowInputForm;
        event EventHandler ShowAboutForm;
    }
}
