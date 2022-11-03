using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models.IRepository
{
    interface IRiskDiagnosisResultRepository
    {
        RiskDiagnosisResult Find(DateTime id);
        bool Add(RiskDiagnosisResult hist);
        bool Delete(DateTime id);
    }
}
