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
    public partial class ChangePassForm : Form
    {
        public ChangePassForm(string token)
        {
            this.accessToken = token;
            InitializeComponent();
        }

        WebApiHelper _helper = new WebApiHelper("api/");
        string accessToken = "";

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                _helper.ChangePassword(
                    textBoxOld.Text,
                    textBoxNew.Text,
                    textBoxConfirm.Text,
                    accessToken);    
                this.Close();
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
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
