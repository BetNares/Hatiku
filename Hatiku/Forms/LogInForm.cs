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
using static System.Windows.Forms.DataFormats;

namespace Hatiku.Forms
{
    public partial class LogInForm : Form, ILoginForm
    {
        public event EventHandler Login;

        public string Username 
        { 
            get => tbUsername.Text; 
            set => tbUsername.Text = value; 
        }

        public string Password {
            get => tbPassword.Text; set => tbPassword.Text = value; }

        public LogInForm()
        {
            InitializeComponent();
            btnLogIn.Click += delegate { Login?.Invoke(this, EventArgs.Empty); };
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static LogInForm _loginForm;
        public static LogInForm GetMenu()
        {
            if (_loginForm == null || _loginForm.IsDisposed)
            {
                _loginForm = new LogInForm();
            }
            else
            {
                _loginForm.WindowState = _loginForm.WindowState == FormWindowState.Minimized ?
                                                    FormWindowState.Normal : _loginForm.WindowState;
                _loginForm.BringToFront();
            }
            return _loginForm;
        }
    }
}
