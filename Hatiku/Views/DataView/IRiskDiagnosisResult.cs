using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Views.EventView;


namespace Hatiku.Views.DataView
{
    public interface IRiskDiagnosisResult: IEventView, IUpdateEventView
    {
        DateTime ResultId { get; set; }
        float RiskResult { get; set; }

        void SetRiskResultBindingSource(BindingSource riskResultBindingSource);
    }
}
