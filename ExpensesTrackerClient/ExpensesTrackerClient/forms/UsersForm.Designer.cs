namespace ExpensesTrackerClient.forms
{
    partial class UsersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGetAllUsers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGetByID = new System.Windows.Forms.Button();
            this.buttonGetByName = new System.Windows.Forms.Button();
            this.textBoxGetById = new System.Windows.Forms.TextBox();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.textBoxGetByName = new System.Windows.Forms.TextBox();
            this.textBoxRoles = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxlastName = new System.Windows.Forms.TextBox();
            this.textBoxUsernam = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labellastName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelRoles = new System.Windows.Forms.Label();
            this.labelFinded = new System.Windows.Forms.Label();
            this.buttonManageRoles = new System.Windows.Forms.Button();
            this.textBoxManageRoles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(514, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonGetAllUsers
            // 
            this.buttonGetAllUsers.Location = new System.Drawing.Point(13, 294);
            this.buttonGetAllUsers.Name = "buttonGetAllUsers";
            this.buttonGetAllUsers.Size = new System.Drawing.Size(75, 27);
            this.buttonGetAllUsers.TabIndex = 1;
            this.buttonGetAllUsers.Text = "Get All";
            this.buttonGetAllUsers.UseVisualStyleBackColor = true;
            this.buttonGetAllUsers.Click += new System.EventHandler(this.buttonGetAllUsers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGetByID
            // 
            this.buttonGetByID.Location = new System.Drawing.Point(13, 361);
            this.buttonGetByID.Name = "buttonGetByID";
            this.buttonGetByID.Size = new System.Drawing.Size(75, 27);
            this.buttonGetByID.TabIndex = 3;
            this.buttonGetByID.Text = "Get by ID";
            this.buttonGetByID.UseVisualStyleBackColor = true;
            this.buttonGetByID.Click += new System.EventHandler(this.buttonGetByID_Click);
            // 
            // buttonGetByName
            // 
            this.buttonGetByName.Location = new System.Drawing.Point(13, 394);
            this.buttonGetByName.Name = "buttonGetByName";
            this.buttonGetByName.Size = new System.Drawing.Size(119, 29);
            this.buttonGetByName.TabIndex = 4;
            this.buttonGetByName.Text = "Get by Name";
            this.buttonGetByName.UseVisualStyleBackColor = true;
            this.buttonGetByName.Click += new System.EventHandler(this.buttonGetByName_Click);
            // 
            // textBoxGetById
            // 
            this.textBoxGetById.Location = new System.Drawing.Point(95, 361);
            this.textBoxGetById.Name = "textBoxGetById";
            this.textBoxGetById.Size = new System.Drawing.Size(37, 22);
            this.textBoxGetById.TabIndex = 5;
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(95, 328);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(37, 22);
            this.textBoxDelete.TabIndex = 6;
            // 
            // textBoxGetByName
            // 
            this.textBoxGetByName.Location = new System.Drawing.Point(138, 394);
            this.textBoxGetByName.Name = "textBoxGetByName";
            this.textBoxGetByName.Size = new System.Drawing.Size(192, 22);
            this.textBoxGetByName.TabIndex = 7;
            // 
            // textBoxRoles
            // 
            this.textBoxRoles.Location = new System.Drawing.Point(644, 265);
            this.textBoxRoles.Name = "textBoxRoles";
            this.textBoxRoles.ReadOnly = true;
            this.textBoxRoles.Size = new System.Drawing.Size(100, 22);
            this.textBoxRoles.TabIndex = 8;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(644, 181);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // textBoxlastName
            // 
            this.textBoxlastName.Location = new System.Drawing.Point(644, 209);
            this.textBoxlastName.Name = "textBoxlastName";
            this.textBoxlastName.ReadOnly = true;
            this.textBoxlastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxlastName.TabIndex = 10;
            // 
            // textBoxUsernam
            // 
            this.textBoxUsernam.Location = new System.Drawing.Point(644, 237);
            this.textBoxUsernam.Name = "textBoxUsernam";
            this.textBoxUsernam.ReadOnly = true;
            this.textBoxUsernam.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsernam.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(644, 153);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 12;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(644, 125);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 13;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(555, 125);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 17);
            this.labelId.TabIndex = 14;
            this.labelId.Text = "ID";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(555, 153);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(555, 181);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 17);
            this.labelFirstName.TabIndex = 16;
            this.labelFirstName.Text = "First Name";
            // 
            // labellastName
            // 
            this.labellastName.AutoSize = true;
            this.labellastName.Location = new System.Drawing.Point(555, 209);
            this.labellastName.Name = "labellastName";
            this.labellastName.Size = new System.Drawing.Size(76, 17);
            this.labellastName.TabIndex = 17;
            this.labellastName.Text = "Last Name";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(555, 237);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 17);
            this.labelUsername.TabIndex = 18;
            this.labelUsername.Text = "Username";
            // 
            // labelRoles
            // 
            this.labelRoles.AutoSize = true;
            this.labelRoles.Location = new System.Drawing.Point(555, 265);
            this.labelRoles.Name = "labelRoles";
            this.labelRoles.Size = new System.Drawing.Size(44, 17);
            this.labelRoles.TabIndex = 19;
            this.labelRoles.Text = "Roles";
            // 
            // labelFinded
            // 
            this.labelFinded.AutoSize = true;
            this.labelFinded.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFinded.Location = new System.Drawing.Point(553, 61);
            this.labelFinded.Name = "labelFinded";
            this.labelFinded.Size = new System.Drawing.Size(168, 29);
            this.labelFinded.TabIndex = 20;
            this.labelFinded.Text = "Queried Data";
            // 
            // buttonManageRoles
            // 
            this.buttonManageRoles.Location = new System.Drawing.Point(388, 323);
            this.buttonManageRoles.Name = "buttonManageRoles";
            this.buttonManageRoles.Size = new System.Drawing.Size(139, 27);
            this.buttonManageRoles.TabIndex = 21;
            this.buttonManageRoles.Text = "Manage Roles";
            this.buttonManageRoles.UseVisualStyleBackColor = true;
            this.buttonManageRoles.Click += new System.EventHandler(this.buttonManageRoles_Click);
            // 
            // textBoxManageRoles
            // 
            this.textBoxManageRoles.Location = new System.Drawing.Point(388, 366);
            this.textBoxManageRoles.Name = "textBoxManageRoles";
            this.textBoxManageRoles.Size = new System.Drawing.Size(139, 22);
            this.textBoxManageRoles.TabIndex = 22;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 429);
            this.Controls.Add(this.textBoxManageRoles);
            this.Controls.Add(this.buttonManageRoles);
            this.Controls.Add(this.labelFinded);
            this.Controls.Add(this.labelRoles);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labellastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxUsernam);
            this.Controls.Add(this.textBoxlastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxRoles);
            this.Controls.Add(this.textBoxGetByName);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.textBoxGetById);
            this.Controls.Add(this.buttonGetByName);
            this.Controls.Add(this.buttonGetByID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGetAllUsers);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGetAllUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGetByID;
        private System.Windows.Forms.Button buttonGetByName;
        private System.Windows.Forms.TextBox textBoxGetById;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.TextBox textBoxGetByName;
        private System.Windows.Forms.TextBox textBoxRoles;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxlastName;
        private System.Windows.Forms.TextBox textBoxUsernam;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labellastName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelRoles;
        private System.Windows.Forms.Label labelFinded;
        private System.Windows.Forms.Button buttonManageRoles;
        private System.Windows.Forms.TextBox textBoxManageRoles;
    }
}