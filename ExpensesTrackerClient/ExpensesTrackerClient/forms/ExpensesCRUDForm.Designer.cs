namespace ExpensesTrackerClient.forms
{
    partial class ExpensesCRUDForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewExpenses = new System.Windows.Forms.DataGridView();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textDelete = new System.Windows.Forms.TextBox();
            this.buttonSearchById = new System.Windows.Forms.Button();
            this.textBoxSearchByID = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonShowAllExpenses = new System.Windows.Forms.Button();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelTotalAmountPerTime = new System.Windows.Forms.Label();
            this.labelExpensesPerDay = new System.Windows.Forms.Label();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.buttonAdminDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewExpenses
            // 
            this.dataGridViewExpenses.AllowUserToOrderColumns = true;
            this.dataGridViewExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenses.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewExpenses.Name = "dataGridViewExpenses";
            this.dataGridViewExpenses.ReadOnly = true;
            this.dataGridViewExpenses.RowTemplate.Height = 24;
            this.dataGridViewExpenses.Size = new System.Drawing.Size(757, 218);
            this.dataGridViewExpenses.TabIndex = 0;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(13, 364);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(74, 35);
            this.buttonShowAll.TabIndex = 1;
            this.buttonShowAll.Text = "Show all";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(695, 397);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 25);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(16, 435);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textDelete
            // 
            this.textDelete.Location = new System.Drawing.Point(106, 436);
            this.textDelete.Name = "textDelete";
            this.textDelete.Size = new System.Drawing.Size(55, 22);
            this.textDelete.TabIndex = 5;
            // 
            // buttonSearchById
            // 
            this.buttonSearchById.Location = new System.Drawing.Point(16, 405);
            this.buttonSearchById.Name = "buttonSearchById";
            this.buttonSearchById.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchById.TabIndex = 6;
            this.buttonSearchById.Text = "Get";
            this.buttonSearchById.UseVisualStyleBackColor = true;
            this.buttonSearchById.Click += new System.EventHandler(this.buttonSearchById_Click);
            // 
            // textBoxSearchByID
            // 
            this.textBoxSearchByID.Location = new System.Drawing.Point(106, 406);
            this.textBoxSearchByID.Name = "textBoxSearchByID";
            this.textBoxSearchByID.Size = new System.Drawing.Size(55, 22);
            this.textBoxSearchByID.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(522, 400);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(152, 22);
            this.textBoxDescription.TabIndex = 8;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(522, 429);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(152, 22);
            this.textBoxAmount.TabIndex = 9;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(522, 457);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(152, 22);
            this.textBoxComment.TabIndex = 10;
            this.textBoxComment.TextChanged += new System.EventHandler(this.textBoxComment_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(359, 405);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 17);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Description";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(359, 434);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(56, 17);
            this.labelAmount.TabIndex = 12;
            this.labelAmount.Text = "Amount";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(359, 463);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(67, 17);
            this.labelComment.TabIndex = 13;
            this.labelComment.Text = "Comment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(357, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Expense queried by search";
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBack.Location = new System.Drawing.Point(0, 524);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(782, 31);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(695, 428);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(695, 457);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonShowAllExpenses
            // 
            this.buttonShowAllExpenses.Location = new System.Drawing.Point(6, 64);
            this.buttonShowAllExpenses.Name = "buttonShowAllExpenses";
            this.buttonShowAllExpenses.Size = new System.Drawing.Size(100, 31);
            this.buttonShowAllExpenses.TabIndex = 18;
            this.buttonShowAllExpenses.Text = "Show All";
            this.buttonShowAllExpenses.UseVisualStyleBackColor = true;
            this.buttonShowAllExpenses.Click += new System.EventHandler(this.buttonShowAllExpenses_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(325, 266);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(78, 22);
            this.textBoxFrom.TabIndex = 19;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(409, 266);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(85, 22);
            this.textBoxTo.TabIndex = 20;
            // 
            // labelTotalAmountPerTime
            // 
            this.labelTotalAmountPerTime.AutoSize = true;
            this.labelTotalAmountPerTime.Location = new System.Drawing.Point(564, 288);
            this.labelTotalAmountPerTime.Name = "labelTotalAmountPerTime";
            this.labelTotalAmountPerTime.Size = new System.Drawing.Size(92, 17);
            this.labelTotalAmountPerTime.TabIndex = 21;
            this.labelTotalAmountPerTime.Text = "Total Amount";
            // 
            // labelExpensesPerDay
            // 
            this.labelExpensesPerDay.AutoSize = true;
            this.labelExpensesPerDay.Location = new System.Drawing.Point(595, 317);
            this.labelExpensesPerDay.Name = "labelExpensesPerDay";
            this.labelExpensesPerDay.Size = new System.Drawing.Size(61, 17);
            this.labelExpensesPerDay.TabIndex = 22;
            this.labelExpensesPerDay.Text = "Average";
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Location = new System.Drawing.Point(670, 283);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotalAmount.TabIndex = 23;
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(670, 317);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(100, 22);
            this.textBoxAverage.TabIndex = 24;
            // 
            // buttonAdminDelete
            // 
            this.buttonAdminDelete.Location = new System.Drawing.Point(112, 64);
            this.buttonAdminDelete.Name = "buttonAdminDelete";
            this.buttonAdminDelete.Size = new System.Drawing.Size(97, 31);
            this.buttonAdminDelete.TabIndex = 25;
            this.buttonAdminDelete.Text = "Delete";
            this.buttonAdminDelete.UseVisualStyleBackColor = true;
            this.buttonAdminDelete.Click += new System.EventHandler(this.buttonAdminDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonAdminDelete);
            this.panel1.Controls.Add(this.buttonShowAllExpenses);
            this.panel1.Location = new System.Drawing.Point(16, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 100);
            this.panel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Admin Functions";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(338, 243);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(40, 17);
            this.labelFrom.TabIndex = 27;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(429, 243);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 17);
            this.labelTo.TabIndex = 28;
            this.labelTo.Text = "To";
            // 
            // ExpensesCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.ControlBox = false;
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxAverage);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.labelExpensesPerDay);
            this.Controls.Add(this.labelTotalAmountPerTime);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxSearchByID);
            this.Controls.Add(this.buttonSearchById);
            this.Controls.Add(this.textDelete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.dataGridViewExpenses);
            this.Name = "ExpensesCRUDForm";
            this.Text = "Expenses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExpenses;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textDelete;
        private System.Windows.Forms.Button buttonSearchById;
        private System.Windows.Forms.TextBox textBoxSearchByID;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonShowAllExpenses;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelTotalAmountPerTime;
        private System.Windows.Forms.Label labelExpensesPerDay;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.Button buttonAdminDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
    }
}