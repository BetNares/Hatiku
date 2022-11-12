using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hatiku.Models.IRepository;

namespace Hatiku.Repository
{
    public class MachineLearningRepository : BaseRepository, IMachineLearningApi
    {
        public bool CheckConnection()
        {
            throw new NotImplementedException();
        }
    }
}
