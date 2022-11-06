﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Views.EventView;

namespace Hatiku.Views
{
    public interface IRiskDiagnosisHistory: IEventView, IUpdateEventView, IShowView
    {
        DateTime ResultId { get; set; }
        int RuleId { get; set; }

        void SetRiskHistoryBindingSource(BindingSource riskHistoryBindingSource);
    }
}
