using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hatiku.Views;

namespace Hatiku.Forms
{
    public partial class AdminView : Form, IAdminView
    {
        private string message;
        private bool isSuccess;
        private bool isEdit;

        public AdminView()
        {
            InitializeComponent();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get { return isEdit; } set { isEdit = value; } }
        public bool IsSuccess { get { return isSuccess; } set { isSuccess= value; } }
        public string Message { get { return message; } set { message = value; } }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetAdminListBinding(BindingSource adminList)
        {
            throw new NotImplementedException();
        }
    }
}
