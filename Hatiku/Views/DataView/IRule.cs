using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Views.EventView;

namespace Hatiku.Views.DataView
{
    public interface IRule : IEventView, IUpdateEventView
    {
        int RuleId { get; set; }
        string Evidence { get; set; }
        float HypothesisProbability { get; set; }

        void SetRuleBindingSource(BindingSource ruleBindingSource);
    }
}
