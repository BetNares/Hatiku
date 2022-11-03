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
using Hatiku.Views;

namespace Hatiku.Forms
{
    public partial class AdminDataMenu: Form, IAdminView
    {
        private string _message;
        private bool _isSuccess;
        private bool _isEdit;

            public AdminDataMenu()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
        }

        private void AssociateAndRaiseEvents()
        {
            txtSearch.TextChanged += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

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

        public void SetAdminListBinding(BindingSource adminList)
        {
            dataGridViewAdmin.DataSource = adminList;
        }
    }
}
