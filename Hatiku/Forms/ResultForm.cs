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
    public partial class ResultForm : Form
    {
        public ResultForm(string result)
        {
            InitializeComponent();
            TextBoxResult.Text = result;
        }




        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
