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
    public partial class AdminPolicyMenu : Form, IPolicyView
    {
        private static AdminPolicyMenu _adminPolicyMenu;
        private bool _isEdit;
        private bool _isSuccess;
        private string _message;
        private List<string> _permissions;

        public AdminPolicyMenu()
        {
            InitializeComponent();
            AssociateAndRaiseEvent();
        }


        public int PolicyId 
        { 
            get => int.Parse(txtId.Text);
            set
            {
                int policyId;

                try
                {
                    policyId = value;
                    txtId.Text = policyId.ToString();
                }
                catch
                {
                    MessageBox.Show("Id should be a number", "Warning: wrong input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public string PolicyName { get => txtPolicyName.Text; set => txtPolicyName.Text = value; }
        public string Detail { get => txtDetails.Text; set => txtDetails.Text = value; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
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

        public bool IsEdit 
        { 
            get => _isEdit;
            set => _isEdit = value; 
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler EditEvent;

        public void SetPolicyListBinding(BindingSource policyList)
        {
            dataGridView1.DataSource = policyList;
        }

        private void AssociateAndRaiseEvent()
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

        public static AdminPolicyMenu GetMenu(Form parentContainer)
        {
            if (_adminPolicyMenu == null || _adminPolicyMenu.IsDisposed)
            {
                _adminPolicyMenu = new AdminPolicyMenu();
                _adminPolicyMenu.MdiParent = parentContainer;
                _adminPolicyMenu.Dock = DockStyle.Fill;
            }
            else
            {
                _adminPolicyMenu.WindowState = _adminPolicyMenu.WindowState == FormWindowState.Minimized ?
                                                    FormWindowState.Normal : _adminPolicyMenu.WindowState;
                _adminPolicyMenu.BringToFront();
            }
            return _adminPolicyMenu;
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
