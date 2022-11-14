using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hatiku.Models.IRepository;

namespace Hatiku.Repository
{
    public class RiskDiagnosisHistoryRepository : BaseRepository, IRiskDiagnosisHistoryRepository
    {
        public bool Add(DateTime resultId, int ruleId)
        {
            throw new NotImplementedException();
        }

        public bool Check(DateTime resultId, int ruleId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DateTime id)
        {
            throw new NotImplementedException();
        }
    }
}
