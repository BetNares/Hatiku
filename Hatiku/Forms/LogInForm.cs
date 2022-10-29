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
    public partial class LogInForm : Form
    {
        SignInForm _signInForm;
        public LogInForm()
        {
            InitializeComponent();
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            _signInForm = new SignInForm();

            _signInForm.Location = this.Location;
            _signInForm.StartPosition = FormStartPosition.Manual;
            _signInForm.FormClosing += delegate { this.Show(); };
            _signInForm.Show();
            this.Hide();

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
