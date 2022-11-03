using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Models.IRepository
{
    interface IDiseaseDiagnosisHistoryRepository
    {
        DiseaseDiagnosisHistory Find(DateTime id);
        bool Add(DiseaseDiagnosisHistory hist);
        bool Delete(DateTime id);
    }
}
