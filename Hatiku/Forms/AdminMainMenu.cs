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

            btnPolicy.Click += delegate
            {
                this.lblTitle.Text = this.btnPolicy.Text;
                ShowPolicyView?.Invoke(this, EventArgs.Empty);
            };

            btnAdminPolicy.Click += delegate
            {
                this.lblTitle.Text = this.btnAdminPolicy.Text;
                ShowAdminPolicyView?.Invoke(this, EventArgs.Empty);
            };

            // Diagnosis Buttons
            btnDiagnosisData.Click += delegate
            {
                this.lblTitle.Text = this.btnDiagnosisData.Text;
                ShowDiagnosisData?.Invoke(this, EventArgs.Empty);
            };
        }

        public event EventHandler ShowAdminView;
        public event EventHandler ShowPolicyView;
        public event EventHandler ShowAdminPolicyView;
        public event EventHandler ShowDiagnosisData;

        private static AdminMainMenu _adminMainMenu;
        public static AdminMainMenu GetMenu()
        {
            if (_adminMainMenu == null || _adminMainMenu.IsDisposed)
            {
                _adminMainMenu = new AdminMainMenu();
            }
            else
            {
                _adminMainMenu.WindowState = _adminMainMenu.WindowState == FormWindowState.Minimized ?
                                                    FormWindowState.Normal : _adminMainMenu.WindowState;
                _adminMainMenu.BringToFront();
            }
            return _adminMainMenu;
        }
    }
}
