using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Views.EventView
{
    public interface IUpdateEventView
    {
        bool IsEdit { get; set; }

        event EventHandler EditEvent;
    }
}
