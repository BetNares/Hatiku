using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Models;
using Hatiku.Models.IRepository;
using Hatiku.Views;

namespace Hatiku.Presenters
{
    public class AdminPresenter
    {
        private IAdminRepository adminRepo;
        private IAdminView adminView;
        private BindingSource adminBindingSource;
        IEnumerable<Admin> admins;

        public AdminPresenter(IAdminRepository adminRepo, IAdminView adminView)
        {
            this.adminRepo = adminRepo;
            this.adminView = adminView;
            this.adminBindingSource = new BindingSource();

            // Subscribe event
            this.adminView.AddNewEvent += AddNewAdmin;
            this.adminView.EditEvent += EditAdmin;
            this.adminView.DeleteEvent += DeleteAdmin;
            this.adminView.CancelEvent += CancelEvent;
            this.adminView.SaveEvent += Save;
            this.adminView.SearchEvent += SearchAdmin;

            // Set binding source
            this.adminView.SetAdminListBinding(adminBindingSource);

            // Get Admin Data
            LoadAllAdminData();

            // Load data
            //this.adminView.Show();
        }

        private void LoadAllAdminData()
        {
            admins = this.adminRepo.FetchAll();
            adminBindingSource.DataSource = admins;
        }

        private void AddNewAdmin(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditAdmin(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteAdmin(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Save(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchAdmin(object sender, EventArgs e)
        {
            bool isSearchValueEmpty = string.IsNullOrWhiteSpace(this.adminView.SearchValue);

            admins = isSearchValueEmpty ? this.adminRepo.FetchAll() :
                this.adminRepo.FindByValue(this.adminView.SearchValue);

            adminBindingSource.DataSource = admins;
        }
    }
}
