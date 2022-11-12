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

    public partial class HomeForm : Form
    {
        AboutForm _profileForm;
        InputDataForm _InputDataForm;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckProfile_Click(object sender, EventArgs e)
        {
            _profileForm = new AboutForm();

            _profileForm.Location = this.Location;
            _profileForm.StartPosition = FormStartPosition.Manual;
            _profileForm.FormClosing += delegate { this.Show(); };
            _profileForm.Show();
            this.Hide();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            _InputDataForm = new InputDataForm();

            _InputDataForm.Location = this.Location;
            _InputDataForm.StartPosition = FormStartPosition.Manual;
            _InputDataForm.FormClosing += delegate { this.Show(); };
            _InputDataForm.Show();
            this.Hide();
        }
    }
}
