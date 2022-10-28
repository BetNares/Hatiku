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
    public partial class SignInForm : Form
    {
        LogInForm _logInForm;
        public SignInForm()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            _logInForm = new LogInForm();

            _logInForm.Location = this.Location;
            _logInForm.StartPosition = FormStartPosition.Manual;
            _logInForm.FormClosing += delegate { this.Show(); };
            _logInForm.Show();
            this.Hide();
        }
    }
}
