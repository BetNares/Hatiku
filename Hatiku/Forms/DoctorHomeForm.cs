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

    public partial class DoctorHomeForm : Form, IDoctorHomeView
    {
        public event EventHandler ShowInputForm;
        public event EventHandler ShowAboutForm;


        public DoctorHomeForm()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        private void AssociateAndRaiseEvents()
        {
            this.btnStartTest.Click += delegate { ShowInputForm?.Invoke(this, EventArgs.Empty); };
            this.btnAbout.Click += delegate { ShowAboutForm?.Invoke(this, EventArgs.Empty); };
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static DoctorHomeForm _doctorHomeForm;
        public static DoctorHomeForm GetMenu()
        {
            if (_doctorHomeForm == null || _doctorHomeForm.IsDisposed)
            {
                _doctorHomeForm = new DoctorHomeForm();
            }
            else
            {
                _doctorHomeForm.WindowState = _doctorHomeForm.WindowState == FormWindowState.Minimized ?
                                                    FormWindowState.Normal : _doctorHomeForm.WindowState;
                _doctorHomeForm.BringToFront();
            }
            return _doctorHomeForm;
        }

    }
}
