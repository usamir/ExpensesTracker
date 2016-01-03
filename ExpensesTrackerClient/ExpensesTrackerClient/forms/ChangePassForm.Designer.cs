namespace ExpensesTrackerClient.forms
{
    partial class ChangePassForm
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
            this.labelold = new System.Windows.Forms.Label();
            this.labelnew = new System.Windows.Forms.Label();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.textBoxOld = new System.Windows.Forms.TextBox();
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelold
            // 
            this.labelold.AutoSize = true;
            this.labelold.Location = new System.Drawing.Point(188, 192);
            this.labelold.Name = "labelold";
            this.labelold.Size = new System.Drawing.Size(30, 17);
            this.labelold.TabIndex = 0;
            this.labelold.Text = "Old";
            // 
            // labelnew
            // 
            this.labelnew.AutoSize = true;
            this.labelnew.Location = new System.Drawing.Point(188, 232);
            this.labelnew.Name = "labelnew";
            this.labelnew.Size = new System.Drawing.Size(35, 17);
            this.labelnew.TabIndex = 1;
            this.labelnew.Text = "New";
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Location = new System.Drawing.Point(188, 269);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(56, 17);
            this.labelConfirm.TabIndex = 2;
            this.labelConfirm.Text = "Confirm";
            // 
            // textBoxOld
            // 
            this.textBoxOld.Location = new System.Drawing.Point(279, 187);
            this.textBoxOld.Name = "textBoxOld";
            this.textBoxOld.Size = new System.Drawing.Size(164, 22);
            this.textBoxOld.TabIndex = 3;
            this.textBoxOld.UseSystemPasswordChar = true;
            // 
            // textBoxNew
            // 
            this.textBoxNew.Location = new System.Drawing.Point(279, 227);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.Size = new System.Drawing.Size(164, 22);
            this.textBoxNew.TabIndex = 4;
            this.textBoxNew.UseSystemPasswordChar = true;
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.Location = new System.Drawing.Point(279, 264);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.Size = new System.Drawing.Size(164, 22);
            this.textBoxConfirm.TabIndex = 5;
            this.textBoxConfirm.UseSystemPasswordChar = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSubmit.Location = new System.Drawing.Point(0, 516);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(782, 39);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.textBoxNew);
            this.Controls.Add(this.textBoxOld);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.labelnew);
            this.Controls.Add(this.labelold);
            this.Name = "ChangePassForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ChangePassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelold;
        private System.Windows.Forms.Label labelnew;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.TextBox textBoxOld;
        private System.Windows.Forms.TextBox textBoxNew;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.Button buttonSubmit;
    }
}