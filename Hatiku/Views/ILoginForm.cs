using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Views
{
    public interface ILoginForm
    {
        string Username { get; set; }
        string Password { get; set; }

        event EventHandler Login;
    }
}
