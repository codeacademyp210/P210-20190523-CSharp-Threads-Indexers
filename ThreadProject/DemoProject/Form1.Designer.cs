namespace DemoProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFillUsers = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmActive = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UName,
            this.USurname,
            this.UEmail});
            this.dgvUsers.ContextMenuStrip = this.cmsUser;
            this.dgvUsers.Location = new System.Drawing.Point(12, 74);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(767, 364);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvUsers_CellContextMenuStripNeeded);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // UName
            // 
            this.UName.HeaderText = "Name";
            this.UName.Name = "UName";
            // 
            // USurname
            // 
            this.USurname.HeaderText = "Surname";
            this.USurname.Name = "USurname";
            // 
            // UEmail
            // 
            this.UEmail.HeaderText = "Email";
            this.UEmail.Name = "UEmail";
            // 
            // btnFillUsers
            // 
            this.btnFillUsers.Location = new System.Drawing.Point(12, 21);
            this.btnFillUsers.Name = "btnFillUsers";
            this.btnFillUsers.Size = new System.Drawing.Size(166, 47);
            this.btnFillUsers.TabIndex = 1;
            this.btnFillUsers.Text = "Fill Users";
            this.btnFillUsers.UseVisualStyleBackColor = true;
            this.btnFillUsers.Click += new System.EventHandler(this.btnFillUsers_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(655, 21);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(124, 47);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // cmsUser
            // 
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActive});
            this.cmsUser.Name = "cmsUser";
            this.cmsUser.Size = new System.Drawing.Size(108, 26);
            // 
            // tsmActive
            // 
            this.tsmActive.Name = "tsmActive";
            this.tsmActive.Size = new System.Drawing.Size(180, 22);
            this.tsmActive.Text = "Item 1";
            this.tsmActive.Click += new System.EventHandler(this.tsmActive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnFillUsers);
            this.Controls.Add(this.dgvUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnFillUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn USurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UEmail;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private System.Windows.Forms.ToolStripMenuItem tsmActive;
    }
}

