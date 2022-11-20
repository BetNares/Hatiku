using Hatiku.Models;
using Hatiku.Models.IRepository;
using Hatiku.Utils;
using Hatiku.Views.DataView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Presenters
{
    public class AdminPolicyPresenter
    {
        private IAdminPolicyRepository _repository;
        private IAdminPolicyView _view;

        private BindingSource _bindingSource;
        IEnumerable<AdminPolicy> _adminPolicies;
        private AdminPolicy _newAdminPolicy;

        public AdminPolicyPresenter(IAdminPolicyRepository repo, IAdminPolicyView view)
        {
            _repository = repo;
            _view = view;
            _bindingSource = new BindingSource();

            _newAdminPolicy = null;

            // Subscribe event
            _view.AddNewEvent += AddNewAdminPolicy;
            _view.DeleteEvent += DeleteAdminPolicy;
            _view.CancelEvent += CancelEvent;
            _view.SaveEvent += SaveChange;
            _view.SearchEvent += SearchAdminPolicy;

            // Set binding source
            _view.SetAdminPolicyBinding(_bindingSource);

            // Get Admin Data
            LoadAllAdminPolicyData();

            // Load data
            _view.Show();
        }

        private void SearchAdminPolicy(object sender, EventArgs e)
        {
            bool isSearchValueEmpty = string.IsNullOrWhiteSpace(_view.SearchValue);

            _adminPolicies = isSearchValueEmpty ? _repository.FetchAll() :
                _repository.FindByValue(_view.SearchValue);

            _bindingSource.DataSource = _adminPolicies;
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            Reset();
        }

        private void DeleteAdminPolicy(object sender, EventArgs e)
        {
            try
            {
                var adminPolicyToDelete = (AdminPolicy)_bindingSource.Current;
                _repository.Delete(adminPolicyToDelete.UserId, adminPolicyToDelete.PolicyId);
                _view.IsSuccess = true;
                _view.Message = "Admin deleted successfully";
                LoadAllAdminPolicyData();
            }
            catch
            {
                _view.IsSuccess = false;
                _view.Message = $"An error occured";
            }
        }

        private void AddNewAdminPolicy(object sender, EventArgs e)
        {

            _newAdminPolicy = new AdminPolicy();
            _newAdminPolicy.UserId = _view.UserId;
            _newAdminPolicy.PolicyId= _view.PolicyId;
        }

        private void LoadAllAdminPolicyData()
        {
            _adminPolicies = _repository.FetchAll();
            _bindingSource.DataSource = _adminPolicies;
        }

        private void SaveChange(object sender, EventArgs e)
        {
            try
            {
                ModelValidation.Validate(_newAdminPolicy);

                _repository.Add(_newAdminPolicy);
                _view.Message = "Policies have been successfully attached to Admin";


                _view.IsSuccess = true;

                Reset();
                _newAdminPolicy = null;

                LoadAllAdminPolicyData();
            }
            catch (Exception ex)
            {
                _view.IsSuccess = false;
                _view.Message = ex.Message;
            }
        }

        private void Reset()
        {
            _view.UserId = 00000;
            _view.PolicyId = 00000;
        }
    }
}
