namespace PasswdFinderGUI
{
    partial class addNewFrm
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
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxAppName = new System.Windows.Forms.TextBox();
            this.txtBxLogin = new System.Windows.Forms.TextBox();
            this.txtBxPass = new System.Windows.Forms.TextBox();
            this.txtBx2FA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(12, 180);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 0;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(201, 180);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(75, 23);
            this.bttnAdd.TabIndex = 1;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add a new login form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "App Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login Credentials";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "2FA";
            // 
            // txtBxAppName
            // 
            this.txtBxAppName.Location = new System.Drawing.Point(75, 46);
            this.txtBxAppName.Name = "txtBxAppName";
            this.txtBxAppName.Size = new System.Drawing.Size(201, 20);
            this.txtBxAppName.TabIndex = 7;
            // 
            // txtBxLogin
            // 
            this.txtBxLogin.Location = new System.Drawing.Point(106, 72);
            this.txtBxLogin.Name = "txtBxLogin";
            this.txtBxLogin.Size = new System.Drawing.Size(170, 20);
            this.txtBxLogin.TabIndex = 8;
            // 
            // txtBxPass
            // 
            this.txtBxPass.Location = new System.Drawing.Point(75, 98);
            this.txtBxPass.Name = "txtBxPass";
            this.txtBxPass.Size = new System.Drawing.Size(201, 20);
            this.txtBxPass.TabIndex = 9;
            // 
            // txtBx2FA
            // 
            this.txtBx2FA.Location = new System.Drawing.Point(44, 124);
            this.txtBx2FA.Name = "txtBx2FA";
            this.txtBx2FA.Size = new System.Drawing.Size(232, 20);
            this.txtBx2FA.TabIndex = 10;
            // 
            // addNewFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 215);
            this.Controls.Add(this.txtBx2FA);
            this.Controls.Add(this.txtBxPass);
            this.Controls.Add(this.txtBxLogin);
            this.Controls.Add(this.txtBxAppName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.bttnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addNewFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New";
            this.Load += new System.EventHandler(this.addNewFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxAppName;
        private System.Windows.Forms.TextBox txtBxLogin;
        private System.Windows.Forms.TextBox txtBxPass;
        private System.Windows.Forms.TextBox txtBx2FA;
    }
}