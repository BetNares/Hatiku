using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models
{
    public class RiskDiagnosisResult
    {
        private DateTime _resultId;
        private float _riskResult;

        public DateTime ResultId { get => _resultId; set => _resultId = value; }
        public float RiskResult { get => _riskResult; set => _riskResult = value;}

    }
}
