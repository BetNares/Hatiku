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
            _signInForm = new SignInForm();
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            _signInForm.Show();
        }
    }
}
