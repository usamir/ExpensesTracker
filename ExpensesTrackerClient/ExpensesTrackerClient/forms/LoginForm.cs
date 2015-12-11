using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTrackerClient.forms
{

    public partial class LoginForm : Form
    {
        #region Properties

        private string _AccessToken = "";

        public string AccessToken
        {
            get { return _AccessToken; }
            set { _AccessToken = value; }
        }

        private bool _Authenticated = false;

        public bool Authenticated
        {
            get { return _Authenticated; }
            set { _Authenticated = value; }
        }

        #endregion

        WebApiHelper _helper = new WebApiHelper("api/");

        public LoginForm()
        {
           InitializeComponent();
           string accessToken = AccessToken;
        }

        

        private void Login()
        {
            if (textBoxUsername.Text.Length > 0 && textBoxPassword.Text.Length > 0)
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                Dictionary<string, string> token = _helper.GetToken(username, password);
                if (token.Count == 2)
                {
                    MessageBox.Show(token["error_description"]);
                }
                else
                {
                    Authenticated = true;
                    AccessToken = token["access_token"];
                    MessageBox.Show("You have logged in successfully!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You need to enter both a username and a password to continue");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
            if (reg.Registered)
                MessageBox.Show("Successfully registered user: " + reg.Username);
        }
    }
}
