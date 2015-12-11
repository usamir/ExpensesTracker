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
    public partial class ExpensesCRUDForm : Form
    {
        private Expense _Expense = new Expense();

        public Expense FindedExpense
        {
            get { return _Expense; }
            set { _Expense = value; }
        }
        WebApiHelper _helper = new WebApiHelper("api/");

        string accessToken = "";
        bool isDescriptionUpdated = false;
        bool isAmountUpdated = false;
        bool isCommentUpdated = false;

        public ExpensesCRUDForm(string token)
        {
            this.accessToken = token;
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                if (isAmountUpdated)
                {
                    FindedExpense.Amount = Double.Parse(textBoxAmount.Text);
                }
                if (isCommentUpdated)
                {
                    FindedExpense.Comment = textBoxComment.Text;
                }
                if (isDescriptionUpdated)
                {
                    FindedExpense.Description = textBoxDescription.Text;
                }
                _helper.Put(FindedExpense, accessToken);
                MessageBox.Show("Update is done");
                buttonUpdate.Enabled = false;
                buttonAdd.Enabled = true;
                buttonClear.Enabled = true;
                showAll();
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

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            showAll();
        }

        private void buttonSearchById_Click(object sender, EventArgs e)
        {
            try 
            {
                if (textBoxSearchByID.Text.Length > 0)
                {
                    FindedExpense = _helper.Get(Int32.Parse(textBoxSearchByID.Text), accessToken);
                    textBoxDescription.Text = FindedExpense.Description;
                    textBoxComment.Text = FindedExpense.Comment;
                    textBoxAmount.Text = (FindedExpense.Amount).ToString();
                    MessageBox.Show("Here is your desired expense");
                    buttonUpdate.Enabled = true;
                    buttonAdd.Enabled = false;
                    buttonClear.Enabled = false;
                    textBoxSearchByID.Clear();
                }
                else 
                {
                    MessageBox.Show("You did not specify ID of the expense!");
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

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            
            isDescriptionUpdated = true;
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            
            isAmountUpdated = true;
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            
            isCommentUpdated = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _helper.Delete(Int32.Parse(textDelete.Text), accessToken);
                MessageBox.Show("Expense numbered " + textDelete.Text + " is deleted");
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDescription.Text.Length > 0 &&
                    textBoxAmount.Text.Length > 0)
                {
                    Expense expense = new Expense
                    {
                        DateTime = DateTime.Now,
                        Amount = Double.Parse(textBoxAmount.Text),
                        Comment = textBoxComment.Text,
                        Description = textBoxDescription.Text
                    };

                    _helper.Post(expense, this.accessToken);
                    MessageBox.Show("Successfully created expense");
                    clearTextBoxes();   
                }
                else
                {
                    MessageBox.Show("Must provide amount and description of expense to add it");
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
            catch (ArgumentException arEx)
            {
                MessageBox.Show(arEx.Message);
            }
        }

        private void clearTextBoxes()
        {
            textBoxAmount.Clear();
            textBoxComment.Clear();
            textBoxDescription.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void showAll()
        {
            try
            {
                string fromTime = textBoxFrom.Text;
                string toTime = textBoxTo.Text;
                DateTime from = new DateTime(2015,11,1);
                DateTime to = DateTime.Now;
               
                if (fromTime.Length > 0 &&
                    toTime.Length > 0)
                {
                    if (!DateTime.TryParse(fromTime, out from) ||
                        !DateTime.TryParse(toTime, out to) )
                    {
                        MessageBox.Show("Unable to parse string to datetime, format is year/month/day");
                    }
                }

                IEnumerable<Expense> data = _helper.Get(accessToken, from, to);
                dataGridViewExpenses.DataSource = data;
                double totalAmount = 0;
                foreach (Expense exp in data)
                {
                    totalAmount += exp.Amount;
                }
                double numberDays = (to - from).TotalDays;
                double average = totalAmount / numberDays;
                textBoxTotalAmount.Text = totalAmount.ToString();
                textBoxAverage.Text = average.ToString();
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

        private void buttonShowAllExpenses_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Expense> data = _helper.GetAll(accessToken);
                dataGridViewExpenses.DataSource = data;
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

        private void buttonAdminDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _helper.DeleteByAdmin(Int32.Parse(textDelete.Text), accessToken);
                MessageBox.Show("Expense numbered " + textDelete.Text + " is deleted");
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
