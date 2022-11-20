using Hatiku.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatiku.Forms
{
    public partial class MainEntryForm : Form, IMainEntryView
    {

        public MainEntryForm()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        public event EventHandler ShowAdminLogin;
        public event EventHandler ShowDoctorHome;

        private void AssociateAndRaiseEvents()
        {
            this.btnAdmin.Click += delegate { ShowAdminLogin?.Invoke(this, EventArgs.Empty); };
            this.btnDoctor.Click += delegate { ShowDoctorHome?.Invoke(this, EventArgs.Empty); };
        }
    }
}
