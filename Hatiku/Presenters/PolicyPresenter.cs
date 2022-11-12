using Hatiku.Models;
using Hatiku.Models.IRepository;
using Hatiku.Views;
using Hatiku.Views.DataView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Presenters
{
    public class PolicyPresenter
    {

        private IPolicyView policyView;
        private IPolicyRepository policyRepository;
        IEnumerable<Policy> policy;

        public PolicyPresenter(IPolicyView policyView, IPolicyRepository policyRepository)
        {
            this.policyView = policyView;
            this.policyRepository = policyRepository;


        }
    }
}
