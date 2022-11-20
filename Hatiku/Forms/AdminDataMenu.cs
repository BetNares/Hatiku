using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using Hatiku.Views.DataView;
using Hatiku.Utils;
using Hatiku.Presenters;
using Hatiku.Views;

namespace Hatiku.Forms
{
    public partial class AdminDataMenu: Form, IAdminView
    {
        private string _message;
        private bool _isSuccess;
        private bool _isEdit;
        private List<string> _permissions;

        public AdminDataMenu()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        public int UserId 
        {
            get => int.Parse(txtId.Text);
            set
            {
                int userId;

                try
                {
                    userId = value;
                    txtId.Text = userId.ToString();
                }
                catch
                {
                    MessageBox.Show("Id should be a number", "Warning: wrong input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }

        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }

        public string SearchValue 
        { 
            get => txtSearch.Text.ToString(); 
            set => txtSearch.Text = value; 
        }

        public bool IsEdit 
        { 
            get { return _isEdit; } 
            set { _isEdit = value; } 
        }

        public bool IsSuccess 
        { 
            get { return _isSuccess; } 
            set { _isSuccess = value; } 
        }

        public string Message 
        { 
            get { return _message; } 
            set { _message = value; } 
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private static AdminDataMenu _adminDataMenuForm;
        public static AdminDataMenu GetMenu(Form parentContainer)
        {
            if (_adminDataMenuForm == null || _adminDataMenuForm.IsDisposed)
            {
                _adminDataMenuForm = new AdminDataMenu();
                _adminDataMenuForm.MdiParent = parentContainer;
                _adminDataMenuForm.Dock = DockStyle.Fill;
            }
            else
            {
                _adminDataMenuForm.WindowState = _adminDataMenuForm.WindowState == FormWindowState.Minimized ?
                                                    FormWindowState.Normal : _adminDataMenuForm.WindowState;
                _adminDataMenuForm.BringToFront();
            }
            return _adminDataMenuForm;
        }

        private void AssociateAndRaiseEvents()
        {
            txtSearch.TextChanged += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            btnAdd.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };
            btnEdit.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            btnDelete.Click += delegate 
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            btnSave.Click += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            btnCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
        }

        public void SetAdminListBinding(BindingSource adminList)
        {
            dataGridViewAdmin.DataSource = adminList;
        }

        public new void Show()
        {
            // Cek terlebih dahulu apakah admin boleh mengakses atau tidak
            if (AccessControl.CheckAuthorization(_permissions))
                base.Show();
            else
            {
                IErrorHandlerView errorHandler = ErrorHandlerForm.GetMenu((AdminMainMenu)MdiParent);

                string msgTitle = "Tidak Ada Izin";
                string msg = "Anda tidak memiliki izin untuk mengakses menu ini. " + 
                    "Hubungi Administrator Anda untuk meminta izin akses.";

                _ = new ErrorHandlerFormPresenter(errorHandler, msgTitle, msg);
            }
        }
    }
}
