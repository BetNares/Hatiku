using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Models;
using Hatiku.Models.IRepository;
using Hatiku.Utils;
using Hatiku.Views;
using Hatiku.Views.DataView;

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
            adminView.AddNewEvent += AddNewAdmin;
            adminView.EditEvent += EditAdmin;
            adminView.DeleteEvent += DeleteAdmin;
            adminView.CancelEvent += CancelEvent;
            adminView.SaveEvent += Save;
            adminView.SearchEvent += SearchAdmin;

            // Set binding source
            adminView.SetAdminListBinding(adminBindingSource);

            // Get Admin Data
            LoadAllAdminData();

            // Load data
            ((Form)this.adminView).Show();
        }

        private void LoadAllAdminData()
        {
            admins = adminRepo.FetchAll();
            adminBindingSource.DataSource = admins;
        }

        private void Reset()
        {
            adminView.UserId = 00000;
            adminView.Username = "";
            adminView.Password = "";
        }

        private void AddNewAdmin(object sender, EventArgs e)
        {
            adminView.IsEdit = false;
        }

        private void EditAdmin(object sender, EventArgs e)
        {
            Admin adminToEdit = (Admin)adminBindingSource.Current;

            adminView.UserId = adminToEdit.Id;
            adminView.Username = adminToEdit.Username;
            adminView.Password = adminToEdit.Password;
            
            adminView.IsEdit = true;
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            Reset();
        }

        private void DeleteAdmin(object sender, EventArgs e)
        {
            try
            {
                var adminToDelete = (Admin)adminBindingSource.Current;
                adminRepo.Delete(adminToDelete.Id);
                adminView.IsSuccess = true;
                adminView.Message = "Admin deleted successfully";
                LoadAllAdminData();
            }
            catch
            {
                adminView.IsSuccess = false;
                adminView.Message = $"An error occured";
            }
        }

        private void Save(object sender, EventArgs e)
        {
            var admin = new Admin();
            admin.Id = adminView.UserId;
            admin.Username = adminView.Username;
            admin.Password = adminView.Password;

            try
            {
                ModelValidation.Validate(admin);
                if (!adminView.IsEdit)
                {
                    adminRepo.Add(admin);
                    adminView.Message = "Admin added successfully";
                } 
                else
                {
                    adminRepo.Edit(admin);
                    adminView.Message = "Admin edited successfully";
                }
                adminView.IsSuccess = true;
                LoadAllAdminData();
            }
            catch (Exception ex)
            {
                adminView.IsSuccess = false;
                adminView.Message = ex.Message;
            }
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
