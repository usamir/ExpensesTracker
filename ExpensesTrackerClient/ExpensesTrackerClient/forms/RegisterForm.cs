using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTrackerClient.forms
{
    public partial class RegisterForm : Form
    {
        WebApiHelper _helper = new WebApiHelper("api/");
        #region "Properties"

        private bool _Registered = false;

        public bool Registered
        {
            get { return _Registered; }
            set { _Registered = value; }
        }

        private string _Username = "";
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        #endregion
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Registered = false; // tell calling form the user DID NOT register
            this.Close(); // close the form
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                _helper.Register(
                    textBoxUsername.Text,
                    textBoxPassword.Text,
                    textBoxConfirmPass.Text,
                    textBoxFirstName.Text,
                    textBoxLastName.Text,
                    textBoxEmail.Text
                    );
                Registered = true;
                Username = textBoxUsername.Text;
                this.Close();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ApiException apiEx)
            {
                var sb = new StringBuilder();
                sb.AppendLine("  An Error Occurred:");
                sb.AppendLine(string.Format("    Status Code: {0}", apiEx.StatusCode.ToString()));
                sb.AppendLine("    Errors:");
                foreach (var error in apiEx.Errors)
                {
                    sb.AppendLine("      " + error);
                }
                MessageBox.Show(sb.ToString());
            }
            catch (AggregateException ex)
            {
                string message = "One or more exceptions has occurred:";
                foreach (var exception in ex.InnerExceptions)
                {
                    message += "  " + exception.Message;
                }
                MessageBox.Show(message);
            }
        }
    }
}
