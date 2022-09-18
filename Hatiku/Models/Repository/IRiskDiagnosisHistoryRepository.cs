using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models.Repository
{
    interface IRiskDiagnosisHistoryRepository
    {
        bool Check(DateTime resultId, int ruleId);
        bool Add(DateTime resultId, int ruleId);
        bool Delete(DateTime id);
    }
}
