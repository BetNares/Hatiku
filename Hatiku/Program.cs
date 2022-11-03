using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Forms;
using Hatiku.Views;
using Hatiku.Models.IRepository;
using Hatiku.Presenters;
using Hatiku.Repository;
using System.Configuration;

namespace Hatiku
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            IAdminRepository adminRepository = new AdminRepository(connectionString);
            IAdminView adminView = new AdminDataMenu();
            new AdminPresenter(adminRepository, adminView);

            Application.Run((Form)adminView);
        }
    }
}