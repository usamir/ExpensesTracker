using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpensesTrackerClient.forms;

namespace ExpensesTrackerClient
{
    
    public partial class ExpensesForm : Form
    {

        LoginForm _loginForm = new LoginForm();

        public ExpensesForm()
        {
            
            InitializeComponent();
            _loginForm.ShowDialog();
            if (!_loginForm.Authenticated)
            {
                Application.Exit();
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            ExpensesCRUDForm _expenseForm = new ExpensesCRUDForm(_loginForm.AccessToken);
            this.Hide();
            _expenseForm.ShowDialog();
            this.Show();
        }

        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            UsersForm _usersForm = new UsersForm(_loginForm.AccessToken);
            this.Hide();
            _usersForm.ShowDialog();
            this.Show();
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            ChangePassForm _change = new ChangePassForm(_loginForm.AccessToken);
            this.Hide();
            _change.ShowDialog();
            this.Show();
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            _loginForm.Authenticated = false;
            _loginForm.AccessToken = "";
            _loginForm.ShowDialog();
            this.Show();
        }
    }
}
