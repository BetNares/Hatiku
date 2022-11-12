using Hatiku.Models;
using Hatiku.Models.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Repository
{
    public class DiseaseDiagnosisHistoryRepository : BaseRepository, IDiseaseDiagnosisHistoryRepository
    {
        public bool Add(DiseaseDiagnosisHistory hist)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DateTime id)
        {
            throw new NotImplementedException();
        }

        public DiseaseDiagnosisHistory Find(DateTime id)
        {
            throw new NotImplementedException();
        }
    }
}
