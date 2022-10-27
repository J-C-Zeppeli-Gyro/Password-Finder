namespace PasswdFinderGUI
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.bttnLoad = new System.Windows.Forms.Button();
            this.txtBxForQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBx = new System.Windows.Forms.ListBox();
            this.bttnChanger = new System.Windows.Forms.Button();
            this.bttnOnlyAccount = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.bttnListAllPrittyPrint = new System.Windows.Forms.Button();
            this.bttnCopyPasswd = new System.Windows.Forms.Button();
            this.bttnCopyLoginCred = new System.Windows.Forms.Button();
            this.bttnDroptxt = new System.Windows.Forms.Button();
            this.lstVw = new System.Windows.Forms.ListView();
            this.bttnAddNew = new System.Windows.Forms.Button();
            this.mnStrp = new System.Windows.Forms.MenuStrip();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemDefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnLoad
            // 
            this.bttnLoad.AllowDrop = true;
            this.bttnLoad.BackColor = System.Drawing.Color.Gainsboro;
            this.bttnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLoad.Location = new System.Drawing.Point(12, 37);
            this.bttnLoad.Name = "bttnLoad";
            this.bttnLoad.Size = new System.Drawing.Size(90, 59);
            this.bttnLoad.TabIndex = 0;
            this.bttnLoad.Text = "Load";
            this.bttnLoad.UseVisualStyleBackColor = false;
            this.bttnLoad.Click += new System.EventHandler(this.LoadList_Click);
            // 
            // txtBxForQuery
            // 
            this.txtBxForQuery.Location = new System.Drawing.Point(12, 178);
            this.txtBxForQuery.Name = "txtBxForQuery";
            this.txtBxForQuery.Size = new System.Drawing.Size(177, 20);
            this.txtBxForQuery.TabIndex = 1;
            this.txtBxForQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxForQuery_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(8, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Which account should I get\nan email and password for?\n(Keyword is enough)";
            // 
            // lstBx
            // 
            this.lstBx.FormattingEnabled = true;
            this.lstBx.Location = new System.Drawing.Point(204, 37);
            this.lstBx.Name = "lstBx";
            this.lstBx.Size = new System.Drawing.Size(768, 576);
            this.lstBx.TabIndex = 3;
            // 
            // bttnChanger
            // 
            this.bttnChanger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnChanger.Location = new System.Drawing.Point(12, 554);
            this.bttnChanger.Name = "bttnChanger";
            this.bttnChanger.Size = new System.Drawing.Size(180, 59);
            this.bttnChanger.TabIndex = 4;
            this.bttnChanger.Text = "Changer";
            this.bttnChanger.UseVisualStyleBackColor = true;
            this.bttnChanger.Click += new System.EventHandler(this.bttnChanger_Click);
            // 
            // bttnOnlyAccount
            // 
            this.bttnOnlyAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnOnlyAccount.Location = new System.Drawing.Point(12, 359);
            this.bttnOnlyAccount.Name = "bttnOnlyAccount";
            this.bttnOnlyAccount.Size = new System.Drawing.Size(180, 59);
            this.bttnOnlyAccount.TabIndex = 5;
            this.bttnOnlyAccount.Text = "Only the account";
            this.bttnOnlyAccount.UseVisualStyleBackColor = true;
            this.bttnOnlyAccount.Click += new System.EventHandler(this.AccountList_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnSearch.Location = new System.Drawing.Point(12, 204);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(177, 31);
            this.bttnSearch.TabIndex = 6;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // bttnListAllPrittyPrint
            // 
            this.bttnListAllPrittyPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnListAllPrittyPrint.Location = new System.Drawing.Point(12, 424);
            this.bttnListAllPrittyPrint.Name = "bttnListAllPrittyPrint";
            this.bttnListAllPrittyPrint.Size = new System.Drawing.Size(180, 59);
            this.bttnListAllPrittyPrint.TabIndex = 7;
            this.bttnListAllPrittyPrint.Text = "List All\n";
            this.bttnListAllPrittyPrint.UseVisualStyleBackColor = true;
            this.bttnListAllPrittyPrint.Click += new System.EventHandler(this.bttnListAllPrittyPrint_Click);
            // 
            // bttnCopyPasswd
            // 
            this.bttnCopyPasswd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnCopyPasswd.Location = new System.Drawing.Point(12, 279);
            this.bttnCopyPasswd.Name = "bttnCopyPasswd";
            this.bttnCopyPasswd.Size = new System.Drawing.Size(177, 31);
            this.bttnCopyPasswd.TabIndex = 8;
            this.bttnCopyPasswd.Text = "Copy Password";
            this.bttnCopyPasswd.UseVisualStyleBackColor = true;
            this.bttnCopyPasswd.Click += new System.EventHandler(this.bttnCopyPasswd_Click);
            // 
            // bttnCopyLoginCred
            // 
            this.bttnCopyLoginCred.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnCopyLoginCred.Location = new System.Drawing.Point(12, 242);
            this.bttnCopyLoginCred.Name = "bttnCopyLoginCred";
            this.bttnCopyLoginCred.Size = new System.Drawing.Size(177, 31);
            this.bttnCopyLoginCred.TabIndex = 9;
            this.bttnCopyLoginCred.Text = "Copy the login credentials";
            this.bttnCopyLoginCred.UseVisualStyleBackColor = true;
            this.bttnCopyLoginCred.Click += new System.EventHandler(this.bttnCopyLoginCred_Click);
            // 
            // bttnDroptxt
            // 
            this.bttnDroptxt.BackColor = System.Drawing.Color.Gainsboro;
            this.bttnDroptxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDroptxt.Location = new System.Drawing.Point(108, 37);
            this.bttnDroptxt.Name = "bttnDroptxt";
            this.bttnDroptxt.Size = new System.Drawing.Size(90, 59);
            this.bttnDroptxt.TabIndex = 10;
            this.bttnDroptxt.Text = "Drop";
            this.bttnDroptxt.UseVisualStyleBackColor = false;
            this.bttnDroptxt.Click += new System.EventHandler(this.bttnDroptxt_Click);
            // 
            // lstVw
            // 
            this.lstVw.GridLines = true;
            this.lstVw.HideSelection = false;
            this.lstVw.Location = new System.Drawing.Point(204, 37);
            this.lstVw.MultiSelect = false;
            this.lstVw.Name = "lstVw";
            this.lstVw.Size = new System.Drawing.Size(0, 0);
            this.lstVw.TabIndex = 11;
            this.lstVw.UseCompatibleStateImageBehavior = false;
            // 
            // bttnAddNew
            // 
            this.bttnAddNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddNew.Location = new System.Drawing.Point(12, 489);
            this.bttnAddNew.Name = "bttnAddNew";
            this.bttnAddNew.Size = new System.Drawing.Size(180, 59);
            this.bttnAddNew.TabIndex = 12;
            this.bttnAddNew.Text = "Add New";
            this.bttnAddNew.UseVisualStyleBackColor = true;
            this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
            // 
            // mnStrp
            // 
            this.mnStrp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mnStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.mnStrp.Location = new System.Drawing.Point(0, 0);
            this.mnStrp.Name = "mnStrp";
            this.mnStrp.Size = new System.Drawing.Size(984, 24);
            this.mnStrp.TabIndex = 13;
            this.mnStrp.Text = "menuStrip1";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.systemDefToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // systemDefToolStripMenuItem
            // 
            this.systemDefToolStripMenuItem.Name = "systemDefToolStripMenuItem";
            this.systemDefToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.systemDefToolStripMenuItem.Text = "System Default";
            this.systemDefToolStripMenuItem.Click += new System.EventHandler(this.systemDefToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.bttnAddNew);
            this.Controls.Add(this.lstVw);
            this.Controls.Add(this.bttnDroptxt);
            this.Controls.Add(this.bttnCopyLoginCred);
            this.Controls.Add(this.bttnCopyPasswd);
            this.Controls.Add(this.bttnListAllPrittyPrint);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.bttnOnlyAccount);
            this.Controls.Add(this.bttnChanger);
            this.Controls.Add(this.lstBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxForQuery);
            this.Controls.Add(this.bttnLoad);
            this.Controls.Add(this.mnStrp);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnStrp;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Finder";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFrm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainFrm_DragEnter);
            this.mnStrp.ResumeLayout(false);
            this.mnStrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnLoad;
        private System.Windows.Forms.TextBox txtBxForQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBx;
        private System.Windows.Forms.Button bttnChanger;
        private System.Windows.Forms.Button bttnOnlyAccount;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.Button bttnListAllPrittyPrint;
        private System.Windows.Forms.Button bttnCopyPasswd;
        private System.Windows.Forms.Button bttnCopyLoginCred;
        private System.Windows.Forms.Button bttnDroptxt;
        private System.Windows.Forms.ListView lstVw;
        private System.Windows.Forms.Button bttnAddNew;
        private System.Windows.Forms.MenuStrip mnStrp;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemDefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
    }
}

