using Hatiku.Models;
using Hatiku.Models.IRepository;
using Hatiku.Utils;
using Hatiku.Views;
using Hatiku.Views.DataView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Presenters
{
    public class PolicyPresenter
    {

        private IPolicyView _policyView;
        private IPolicyRepository _policyRepository;
        IEnumerable<Policy> _policy;
        private BindingSource _policyBindingSource;


        public PolicyPresenter(IPolicyView policyView, IPolicyRepository policyRepository)
        {
            _policyView = policyView;
            _policyRepository = policyRepository;
            _policyBindingSource = new BindingSource();

            _policyView.AddNewEvent += AddNewPolicy;
            _policyView.EditEvent += EditPolicy;
            _policyView.DeleteEvent += DeletePolicy;
            _policyView.CancelEvent += CancelAction;
            _policyView.SaveEvent += SaveChange;
            _policyView.SearchEvent += SearchPolicy;

            _policyView.SetPolicyListBinding(_policyBindingSource);

            LoadAllPolicyData();

            _policyView.Show();
        }

        private void EditPolicy(object sender, EventArgs e)
        {
            Policy policyToEdit = (Policy)_policyBindingSource.Current;

            _policyView.PolicyId = policyToEdit.PolicyId;
            _policyView.PolicyName = policyToEdit.Name;
            _policyView.Detail = policyToEdit.Detail;

            _policyView.IsEdit = true;
        }

        private void SaveChange(object sender, EventArgs e)
        {
            var newPolicy = new Policy();
            newPolicy.PolicyId = _policyView.PolicyId;
            newPolicy.Name = _policyView.PolicyName;
            newPolicy.Detail = _policyView.Detail;

            try
            {
                ModelValidation.Validate(newPolicy);

                _policyRepository.Add(newPolicy);
                _policyView.Message = "Policy added successfully";


                _policyView.IsSuccess = true;

                Reset();
                
                LoadAllPolicyData();
            }
            catch (Exception ex)
            {
                _policyView.IsSuccess = false;
                _policyView.Message = ex.Message;
            }
        }

        private void LoadAllPolicyData()
        {
            _policy = _policyRepository.FetchAll();
            _policyBindingSource.DataSource = _policy;
        }

        private void Reset()
        {
            _policyView.PolicyId = 00000;
            _policyView.PolicyName = "";
            _policyView.Detail = "";
        }


        private void CancelAction(object sender, EventArgs e)
        {
            Reset();
        }

        private void SearchPolicy(object sender, EventArgs e)
        {
            bool isSearchValueEmpty = string.IsNullOrWhiteSpace(_policyView.SearchValue);

            _policy = isSearchValueEmpty ? this._policyRepository.FetchAll() :
                this._policyRepository.FindByValue(_policyView.SearchValue);

            _policyBindingSource.DataSource = _policy;
        }

        private void AddNewPolicy(object sender, EventArgs e)
        {
            _policyView.IsEdit = false;
        }

        private void DeletePolicy(object sender, EventArgs e)
        {
            try
            {
                var policyToDelete = (Policy)_policyBindingSource.Current;
                _policyRepository.Delete(policyToDelete.PolicyId);
                _policyView.IsSuccess = true;
                _policyView.Message = "Policy deleted successfully";
                LoadAllPolicyData();
            }
            catch
            {
                _policyView.IsSuccess = false;
                _policyView.Message = $"An error occured";
            }
        }
    }
}
