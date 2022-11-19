using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Views
{
    public interface IErrorHandlerView
    {
        string Message { get; set; }
        string MessageTitle { get; set; }
        Image InformationImage { get; set; }
    }
}
