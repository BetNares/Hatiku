using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models
{
    public class Rule
    {
        private int _ruleId;
        private string _evidence;
        private float _hypothesisProbability;

        public int RuleId { get => _ruleId; set => _ruleId = value; }
        public string Evidence { get => _evidence; set => _evidence = value; }
        public float HypothesisProbability { get => _hypothesisProbability; set => _hypothesisProbability = value; }
    }
}
