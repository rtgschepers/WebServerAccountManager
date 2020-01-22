namespace WebServerAccountManager
{
    partial class DeletedAccountsViewer
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
            this.dgvDeletedAccounts = new System.Windows.Forms.DataGridView();
            this.dgvFailedAccounts = new System.Windows.Forms.DataGridView();
            this.gbFailedAccounts = new System.Windows.Forms.GroupBox();
            this.gbDeletedAccounts = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailedAccounts)).BeginInit();
            this.gbFailedAccounts.SuspendLayout();
            this.gbDeletedAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDeletedAccounts
            // 
            this.dgvDeletedAccounts.AllowUserToAddRows = false;
            this.dgvDeletedAccounts.AllowUserToDeleteRows = false;
            this.dgvDeletedAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeletedAccounts.Location = new System.Drawing.Point(3, 16);
            this.dgvDeletedAccounts.Name = "dgvDeletedAccounts";
            this.dgvDeletedAccounts.ReadOnly = true;
            this.dgvDeletedAccounts.Size = new System.Drawing.Size(488, 81);
            this.dgvDeletedAccounts.TabIndex = 0;
            // 
            // dgvFailedAccounts
            // 
            this.dgvFailedAccounts.AllowUserToAddRows = false;
            this.dgvFailedAccounts.AllowUserToDeleteRows = false;
            this.dgvFailedAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFailedAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFailedAccounts.Location = new System.Drawing.Point(3, 16);
            this.dgvFailedAccounts.Name = "dgvFailedAccounts";
            this.dgvFailedAccounts.ReadOnly = true;
            this.dgvFailedAccounts.Size = new System.Drawing.Size(488, 166);
            this.dgvFailedAccounts.TabIndex = 1;
            // 
            // gbFailedAccounts
            // 
            this.gbFailedAccounts.Controls.Add(this.dgvFailedAccounts);
            this.gbFailedAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFailedAccounts.Location = new System.Drawing.Point(0, 100);
            this.gbFailedAccounts.Name = "gbFailedAccounts";
            this.gbFailedAccounts.Size = new System.Drawing.Size(494, 185);
            this.gbFailedAccounts.TabIndex = 0;
            this.gbFailedAccounts.TabStop = false;
            this.gbFailedAccounts.Text = "Niet verwijderde accounts";
            // 
            // gbDeletedAccounts
            // 
            this.gbDeletedAccounts.Controls.Add(this.dgvDeletedAccounts);
            this.gbDeletedAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDeletedAccounts.Location = new System.Drawing.Point(0, 0);
            this.gbDeletedAccounts.Name = "gbDeletedAccounts";
            this.gbDeletedAccounts.Size = new System.Drawing.Size(494, 100);
            this.gbDeletedAccounts.TabIndex = 0;
            this.gbDeletedAccounts.TabStop = false;
            this.gbDeletedAccounts.Text = "Verwijderde accounts";
            // 
            // DeletedAccountsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 285);
            this.Controls.Add(this.gbFailedAccounts);
            this.Controls.Add(this.gbDeletedAccounts);
            this.Name = "DeletedAccountsViewer";
            this.Text = "DeletedAccountsViewer";
            this.Load += new System.EventHandler(this.DeletedAccountsViewer_Load);
            this.Resize += new System.EventHandler(this.DeletedAccountsViewer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailedAccounts)).EndInit();
            this.gbFailedAccounts.ResumeLayout(false);
            this.gbDeletedAccounts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeletedAccounts;
        private System.Windows.Forms.DataGridView dgvFailedAccounts;
        private System.Windows.Forms.GroupBox gbFailedAccounts;
        private System.Windows.Forms.GroupBox gbDeletedAccounts;
    }
}