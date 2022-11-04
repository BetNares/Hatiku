using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Views;

namespace Hatiku.Forms
{
    public partial class AdminMainMenu : Form, IAdminMainMenuView
    {
        public AdminMainMenu()
        {
            InitializeComponent();
            btnAdmin.Click += delegate
            {
                this.lblTitle.Text = this.btnAdmin.Text;
                ShowAdminView?.Invoke(this, EventArgs.Empty);
            };

            this.SizeChanged += new EventHandler(adminMainMenu_sizeChanged);
        }

        private void adminMainMenu_sizeChanged(object sender, EventArgs e)
        {
            //this.lblTitle.Location.X = (this.titlePanel.Width / 2) + this.titlePanel.Location.X;
            return;
        }

        public event EventHandler ShowAdminView;
        public event EventHandler ShowPolicyView;
        public event EventHandler ShowExpertSystemView;
        public event EventHandler ShowMachineLearningView;
    }
}
