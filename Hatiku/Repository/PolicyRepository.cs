﻿using Hatiku.Models;
using Hatiku.Models.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Repository
{
    public class PolicyRepository : BaseRepository, IPolicyRepository
    {
        public bool Add(Policy policy)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Policy> FetchAll()
        {
            throw new NotImplementedException();
        }

        public Policy Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
