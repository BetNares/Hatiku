using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models
{
    public class RiskDiagnosisHistory
    {
        private DateTime _resultId;
        private int _ruleId;

        public DateTime ResultId { get => _resultId; set => _resulId = value; }
        public int RuleId { get => _ruleId; set => _ruleId = value; }
    }
}
