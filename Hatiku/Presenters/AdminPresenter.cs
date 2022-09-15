using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Models;
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

            this.adminView.AddNewEvent += AddNewAdmin;
            this.adminView.EditEvent += EditAdmin;
        }

        private void EditAdmin(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewAdmin(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
