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
    public partial class ErrorHandlerForm : Form, IErrorHandlerView
    {
        public ErrorHandlerForm()
        {
            InitializeComponent();
        }

        public string Message { get => lblDetail.Text; set => lblDetail.Text = value; }
        public string MessageTitle { get => lblTitle.Text; set => lblTitle.Text = value; }
        public Image InformationImage { get => pictBox.Image; set => pictBox.Image = value; }

        private static ErrorHandlerForm _errorHandlerForm;
        public static ErrorHandlerForm GetMenu(Form parentContainer)
        {
            if (_errorHandlerForm == null || _errorHandlerForm.IsDisposed)
            {
                _errorHandlerForm = new ErrorHandlerForm();
                _errorHandlerForm.MdiParent = parentContainer;
                _errorHandlerForm.Dock = DockStyle.Fill;
            }
            else
            {
                _errorHandlerForm.WindowState = _errorHandlerForm.WindowState == FormWindowState.Minimized ?
                                                    FormWindowState.Normal : _errorHandlerForm.WindowState;
                _errorHandlerForm.BringToFront();
            }
            return _errorHandlerForm;
        }
    }
}
