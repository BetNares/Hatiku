using Hatiku.Presenters;
using Hatiku.Utils;
using Hatiku.Views;
using Hatiku.Views.DataView;
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
    public partial class AdminAttachPolicy : Form, IAdminPolicyView
    {
        private bool _isEdit;
        private bool _isSuccess;
        private string _message;

        public AdminAttachPolicy()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        public int UserId 
        {
            get => int.Parse(txtUserId.Text);
            set
            {
                int userId;

                try
                {
                    userId = value;
                    txtUserId.Text = userId.ToString();
                }
                catch
                {
                    MessageBox.Show("Id should be a number", "Warning: wrong input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public int PolicyId 
        {
            get => int.Parse(txtPolicyId.Text);
            set
            {
                int policyId;

                try
                {
                    policyId = value;
                    txtPolicyId.Text = policyId.ToString();
                }
                catch
                {
                    MessageBox.Show("Id should be a number", "Warning: wrong input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

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
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private static AdminAttachPolicy _adminAttachPolicyForm;
        private List<string> _permissions;

        public static AdminAttachPolicy GetMenu(Form parentContainer)
        {
            if (_adminAttachPolicyForm == null || _adminAttachPolicyForm.IsDisposed)
            {
                _adminAttachPolicyForm = new AdminAttachPolicy();
                _adminAttachPolicyForm.MdiParent = parentContainer;
                _adminAttachPolicyForm.Dock = DockStyle.Fill;
            }
            else
            {
                _adminAttachPolicyForm.WindowState = _adminAttachPolicyForm.WindowState == FormWindowState.Minimized ?
                                                    FormWindowState.Normal : _adminAttachPolicyForm.WindowState;
                _adminAttachPolicyForm.BringToFront();
            }
            return _adminAttachPolicyForm;
        }
        
        private void AssociateAndRaiseEvents()
        {
            txtSearch.TextChanged += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            btnAdd.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };

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

        public void SetAdminPolicyBinding(BindingSource adminPolicyList)
        {
            dataGridView1.DataSource = adminPolicyList;
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
