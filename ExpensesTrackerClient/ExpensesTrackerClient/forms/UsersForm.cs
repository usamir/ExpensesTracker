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
using ExpensesTrackerClient.Models;

namespace ExpensesTrackerClient.forms
{
    public partial class UsersForm : Form
    {
        string accessToken = "";

        WebApiHelper _helper = new WebApiHelper("api/");

        private ApplicationUser _User = new ApplicationUser();

        public ApplicationUser User
        {
            get { return _User; }
            set { _User = value; }
        }

        public UsersForm(string token)
        {
            this.accessToken = token;
            InitializeComponent();

        }

        private void buttonGetAllUsers_Click(object sender, EventArgs e)
        {
            GetAllUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDelete.Text.Length > 0)
                {
                    _helper.DeleteUser(textBoxDelete.Text, accessToken);
                    textBoxDelete.Clear();
                    GetAllUsers();
                }
                else
                {
                    MessageBox.Show("You did not specify ID of the user!");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
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
            
        }

        private void buttonGetByID_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxGetById.Text.Length > 0)
                {
                    User = _helper.GetUserById(accessToken, textBoxGetById.Text);
                    textBoxId.Text = User.Id;
                    textBoxFirstName.Text = User.FirstName;
                    textBoxlastName.Text = User.LastName;
                    textBoxUsernam.Text = User.UserName;
                    textBoxEmail.Text = User.Email;
                    textBoxRoles.Text = string.Join(" ", User.Roles);
                    
                    textBoxGetById.Clear();
                }
                else
                {
                    MessageBox.Show("You did not specify ID of the user!");
                }

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
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
        }

        private void buttonGetByName_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxGetByName.Text.Length > 0)
                {
                    User = _helper.GetUserByUsername(accessToken, textBoxGetByName.Text);
                    textBoxId.Text = User.Id;
                    textBoxFirstName.Text = User.FirstName;
                    textBoxlastName.Text = User.LastName;
                    textBoxUsernam.Text = User.UserName;
                    textBoxEmail.Text = User.Email;
                    textBoxRoles.Text = string.Join(" ", User.Roles);

                    textBoxGetByName.Clear();
                }
                else
                {
                    MessageBox.Show("You did not specify name of the user!");
                }

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

        private void clearData()
        {
            textBoxId.Clear();
            textBoxFirstName.Clear();
            textBoxlastName.Clear();
            textBoxUsernam.Clear();
            textBoxEmail.Clear();
            textBoxRoles.Clear();
        }

        private void GetAllUsers()
        {
            try
            {
                IEnumerable<ApplicationUser> data = _helper.GetAllUsers(accessToken);
                dataGridView1.DataSource = data;

                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
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

        private void buttonManageRoles_Click(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = textBoxManageRoles.Text.Split(' ');
                _helper.AssignRolesToUser(User.Id, stringArray, accessToken);
                textBoxManageRoles.Clear();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Possible values are: Admin, User and UserManager " + "     " + ex.Message);
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
                sb.AppendLine("Possible values are: Admin, User and UserManager");
                MessageBox.Show(sb.ToString());
            }
            catch (AggregateException ex)
            {
                string message = "One or more exceptions has occurred:";
                foreach (var exception in ex.InnerExceptions)
                {
                    message += "  " + exception.Message;
                }
                message += " " + "Possible values are: Admin, User and UserManager";
                MessageBox.Show(message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
