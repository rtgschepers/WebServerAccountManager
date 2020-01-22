namespace WebServerAccountManager
{
    partial class frmAccountManager
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
            this.tcTabMenu = new System.Windows.Forms.TabControl();
            this.tpCreateAccounts = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbSuccessAccounts = new System.Windows.Forms.GroupBox();
            this.dgvSuccessAccounts = new System.Windows.Forms.DataGridView();
            this.gbFailedAccounts = new System.Windows.Forms.GroupBox();
            this.dgvFailedAccounts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbWebservers = new System.Windows.Forms.GroupBox();
            this.cmbWebservers = new System.Windows.Forms.ComboBox();
            this.bsWebservers = new System.Windows.Forms.BindingSource(this.components);
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.btnCreateAccounts = new System.Windows.Forms.Button();
            this.gbGroups = new System.Windows.Forms.GroupBox();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.tpDeleteAccount = new System.Windows.Forms.TabPage();
            this.gbDeleteAccounts = new System.Windows.Forms.GroupBox();
            this.dgvDeleteAccounts = new System.Windows.Forms.DataGridView();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbListType = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkExcludeTeachers = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAccounts = new System.Windows.Forms.Button();
            this.tcTabMenu.SuspendLayout();
            this.tpCreateAccounts.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbSuccessAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccessAccounts)).BeginInit();
            this.gbFailedAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailedAccounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbWebservers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWebservers)).BeginInit();
            this.gbCreate.SuspendLayout();
            this.gbGroups.SuspendLayout();
            this.tpDeleteAccount.SuspendLayout();
            this.gbDeleteAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteAccounts)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTabMenu
            // 
            this.tcTabMenu.Controls.Add(this.tpCreateAccounts);
            this.tcTabMenu.Controls.Add(this.tpDeleteAccount);
            this.tcTabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabMenu.Location = new System.Drawing.Point(0, 0);
            this.tcTabMenu.Name = "tcTabMenu";
            this.tcTabMenu.SelectedIndex = 0;
            this.tcTabMenu.Size = new System.Drawing.Size(467, 468);
            this.tcTabMenu.TabIndex = 0;
            this.tcTabMenu.SelectedIndexChanged += new System.EventHandler(this.tcTabMenu_SelectedIndexChanged);
            // 
            // tpCreateAccounts
            // 
            this.tpCreateAccounts.Controls.Add(this.panel2);
            this.tpCreateAccounts.Controls.Add(this.panel1);
            this.tpCreateAccounts.Location = new System.Drawing.Point(4, 22);
            this.tpCreateAccounts.Name = "tpCreateAccounts";
            this.tpCreateAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreateAccounts.Size = new System.Drawing.Size(459, 442);
            this.tpCreateAccounts.TabIndex = 0;
            this.tpCreateAccounts.Text = "Creëer Accounts";
            this.tpCreateAccounts.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbSuccessAccounts);
            this.panel2.Controls.Add(this.gbFailedAccounts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 381);
            this.panel2.TabIndex = 6;
            // 
            // gbSuccessAccounts
            // 
            this.gbSuccessAccounts.Controls.Add(this.dgvSuccessAccounts);
            this.gbSuccessAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSuccessAccounts.Location = new System.Drawing.Point(0, 0);
            this.gbSuccessAccounts.Name = "gbSuccessAccounts";
            this.gbSuccessAccounts.Size = new System.Drawing.Size(453, 181);
            this.gbSuccessAccounts.TabIndex = 5;
            this.gbSuccessAccounts.TabStop = false;
            this.gbSuccessAccounts.Text = "Succesvol aangemaakte accounts";
            // 
            // dgvSuccessAccounts
            // 
            this.dgvSuccessAccounts.AllowUserToAddRows = false;
            this.dgvSuccessAccounts.AllowUserToDeleteRows = false;
            this.dgvSuccessAccounts.AllowUserToOrderColumns = true;
            this.dgvSuccessAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuccessAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuccessAccounts.Location = new System.Drawing.Point(3, 16);
            this.dgvSuccessAccounts.Name = "dgvSuccessAccounts";
            this.dgvSuccessAccounts.ReadOnly = true;
            this.dgvSuccessAccounts.Size = new System.Drawing.Size(447, 162);
            this.dgvSuccessAccounts.TabIndex = 3;
            // 
            // gbFailedAccounts
            // 
            this.gbFailedAccounts.Controls.Add(this.dgvFailedAccounts);
            this.gbFailedAccounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbFailedAccounts.Location = new System.Drawing.Point(0, 181);
            this.gbFailedAccounts.Name = "gbFailedAccounts";
            this.gbFailedAccounts.Size = new System.Drawing.Size(453, 200);
            this.gbFailedAccounts.TabIndex = 4;
            this.gbFailedAccounts.TabStop = false;
            this.gbFailedAccounts.Text = "Onsuccesvol aangemaakte accounts";
            // 
            // dgvFailedAccounts
            // 
            this.dgvFailedAccounts.AllowUserToAddRows = false;
            this.dgvFailedAccounts.AllowUserToDeleteRows = false;
            this.dgvFailedAccounts.AllowUserToOrderColumns = true;
            this.dgvFailedAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFailedAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFailedAccounts.Location = new System.Drawing.Point(3, 16);
            this.dgvFailedAccounts.Name = "dgvFailedAccounts";
            this.dgvFailedAccounts.ReadOnly = true;
            this.dgvFailedAccounts.Size = new System.Drawing.Size(447, 181);
            this.dgvFailedAccounts.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbWebservers);
            this.panel1.Controls.Add(this.gbCreate);
            this.panel1.Controls.Add(this.gbGroups);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 55);
            this.panel1.TabIndex = 4;
            // 
            // gbWebservers
            // 
            this.gbWebservers.Controls.Add(this.cmbWebservers);
            this.gbWebservers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWebservers.Location = new System.Drawing.Point(112, 0);
            this.gbWebservers.Name = "gbWebservers";
            this.gbWebservers.Size = new System.Drawing.Size(240, 55);
            this.gbWebservers.TabIndex = 1;
            this.gbWebservers.TabStop = false;
            this.gbWebservers.Text = "Selecteer een webserver";
            // 
            // cmbWebservers
            // 
            this.cmbWebservers.DataSource = this.bsWebservers;
            this.cmbWebservers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWebservers.FormattingEnabled = true;
            this.cmbWebservers.Location = new System.Drawing.Point(6, 20);
            this.cmbWebservers.Name = "cmbWebservers";
            this.cmbWebservers.Size = new System.Drawing.Size(208, 21);
            this.cmbWebservers.TabIndex = 0;
            // 
            // gbCreate
            // 
            this.gbCreate.Controls.Add(this.btnCreateAccounts);
            this.gbCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbCreate.Location = new System.Drawing.Point(352, 0);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(101, 55);
            this.gbCreate.TabIndex = 2;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "Creëer accounts";
            // 
            // btnCreateAccounts
            // 
            this.btnCreateAccounts.Location = new System.Drawing.Point(6, 18);
            this.btnCreateAccounts.Name = "btnCreateAccounts";
            this.btnCreateAccounts.Size = new System.Drawing.Size(89, 23);
            this.btnCreateAccounts.TabIndex = 0;
            this.btnCreateAccounts.Text = "START";
            this.btnCreateAccounts.UseVisualStyleBackColor = true;
            this.btnCreateAccounts.Click += new System.EventHandler(this.btnCreateAccounts_Click);
            // 
            // gbGroups
            // 
            this.gbGroups.Controls.Add(this.cmbGroups);
            this.gbGroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbGroups.Location = new System.Drawing.Point(0, 0);
            this.gbGroups.Name = "gbGroups";
            this.gbGroups.Size = new System.Drawing.Size(112, 55);
            this.gbGroups.TabIndex = 0;
            this.gbGroups.TabStop = false;
            this.gbGroups.Text = "Selecteer een klas";
            // 
            // cmbGroups
            // 
            this.cmbGroups.DropDownHeight = 150;
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.IntegralHeight = false;
            this.cmbGroups.Location = new System.Drawing.Point(7, 20);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(99, 21);
            this.cmbGroups.TabIndex = 0;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // tpDeleteAccount
            // 
            this.tpDeleteAccount.Controls.Add(this.gbDeleteAccounts);
            this.tpDeleteAccount.Controls.Add(this.pnlMenu);
            this.tpDeleteAccount.Location = new System.Drawing.Point(4, 22);
            this.tpDeleteAccount.Name = "tpDeleteAccount";
            this.tpDeleteAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeleteAccount.Size = new System.Drawing.Size(459, 442);
            this.tpDeleteAccount.TabIndex = 1;
            this.tpDeleteAccount.Text = "Verwijder Accounts";
            this.tpDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // gbDeleteAccounts
            // 
            this.gbDeleteAccounts.Controls.Add(this.dgvDeleteAccounts);
            this.gbDeleteAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDeleteAccounts.Location = new System.Drawing.Point(3, 53);
            this.gbDeleteAccounts.Name = "gbDeleteAccounts";
            this.gbDeleteAccounts.Size = new System.Drawing.Size(453, 386);
            this.gbDeleteAccounts.TabIndex = 4;
            this.gbDeleteAccounts.TabStop = false;
            this.gbDeleteAccounts.Text = "Accounts die verwijderd moeten worden";
            // 
            // dgvDeleteAccounts
            // 
            this.dgvDeleteAccounts.AllowUserToAddRows = false;
            this.dgvDeleteAccounts.AllowUserToDeleteRows = false;
            this.dgvDeleteAccounts.AllowUserToOrderColumns = true;
            this.dgvDeleteAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeleteAccounts.Location = new System.Drawing.Point(3, 16);
            this.dgvDeleteAccounts.Name = "dgvDeleteAccounts";
            this.dgvDeleteAccounts.ReadOnly = true;
            this.dgvDeleteAccounts.Size = new System.Drawing.Size(447, 367);
            this.dgvDeleteAccounts.TabIndex = 3;
            this.dgvDeleteAccounts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDeleteAccounts_MouseClick);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.groupBox5);
            this.pnlMenu.Controls.Add(this.groupBox6);
            this.pnlMenu.Controls.Add(this.groupBox7);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(3, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(453, 50);
            this.pnlMenu.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbListType);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 50);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selecteer een lijst om te zien";
            // 
            // cmbListType
            // 
            this.cmbListType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListType.FormattingEnabled = true;
            this.cmbListType.Items.AddRange(new object[] {
            "Veilig te verwijderen accounts",
            "Handmatige controle vereist"});
            this.cmbListType.Location = new System.Drawing.Point(6, 20);
            this.cmbListType.Name = "cmbListType";
            this.cmbListType.Size = new System.Drawing.Size(217, 21);
            this.cmbListType.TabIndex = 2;
            this.cmbListType.SelectedIndexChanged += new System.EventHandler(this.cmbListType_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkExcludeTeachers);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox6.Location = new System.Drawing.Point(237, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(113, 50);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Leraren uitsluiten?";
            // 
            // chkExcludeTeachers
            // 
            this.chkExcludeTeachers.AutoSize = true;
            this.chkExcludeTeachers.Location = new System.Drawing.Point(6, 22);
            this.chkExcludeTeachers.Name = "chkExcludeTeachers";
            this.chkExcludeTeachers.Size = new System.Drawing.Size(71, 17);
            this.chkExcludeTeachers.TabIndex = 0;
            this.chkExcludeTeachers.Text = "Uitlsluiten";
            this.chkExcludeTeachers.UseVisualStyleBackColor = true;
            this.chkExcludeTeachers.CheckedChanged += new System.EventHandler(this.chkExcludeTeachers_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnDeleteAccounts);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox7.Location = new System.Drawing.Point(350, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(103, 50);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Veilig verwijderen";
            // 
            // btnDeleteAccounts
            // 
            this.btnDeleteAccounts.Location = new System.Drawing.Point(6, 18);
            this.btnDeleteAccounts.Name = "btnDeleteAccounts";
            this.btnDeleteAccounts.Size = new System.Drawing.Size(80, 23);
            this.btnDeleteAccounts.TabIndex = 0;
            this.btnDeleteAccounts.Text = "Verwijder";
            this.btnDeleteAccounts.UseVisualStyleBackColor = true;
            this.btnDeleteAccounts.Click += new System.EventHandler(this.btnDeleteAccounts_Click);
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 468);
            this.Controls.Add(this.tcTabMenu);
            this.Name = "frmAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Server Account Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcTabMenu.ResumeLayout(false);
            this.tpCreateAccounts.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbSuccessAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccessAccounts)).EndInit();
            this.gbFailedAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailedAccounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbWebservers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsWebservers)).EndInit();
            this.gbCreate.ResumeLayout(false);
            this.gbGroups.ResumeLayout(false);
            this.tpDeleteAccount.ResumeLayout(false);
            this.gbDeleteAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteAccounts)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTabMenu;
        private System.Windows.Forms.TabPage tpCreateAccounts;
        private System.Windows.Forms.TabPage tpDeleteAccount;
        private System.Windows.Forms.GroupBox gbGroups;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.GroupBox gbWebservers;
        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.Button btnCreateAccounts;
        private System.Windows.Forms.GroupBox gbFailedAccounts;
        private System.Windows.Forms.DataGridView dgvFailedAccounts;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnDeleteAccounts;
        private System.Windows.Forms.GroupBox gbDeleteAccounts;
        private System.Windows.Forms.DataGridView dgvDeleteAccounts;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbListType;
        private System.Windows.Forms.ComboBox cmbWebservers;
        private System.Windows.Forms.BindingSource bsWebservers;
        private System.Windows.Forms.GroupBox gbSuccessAccounts;
        private System.Windows.Forms.DataGridView dgvSuccessAccounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkExcludeTeachers;
        private System.Windows.Forms.Panel pnlMenu;
    }
}

