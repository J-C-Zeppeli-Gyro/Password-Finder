namespace PasswdFinderGUI
{
    partial class PsswdChngrFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxNewPasswd = new System.Windows.Forms.TextBox();
            this.bttnGenerateNew = new System.Windows.Forms.Button();
            this.bttnSetPasswd = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set a new password here: (MAX: 50characters)";
            // 
            // txtBxNewPasswd
            // 
            this.txtBxNewPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNewPasswd.Location = new System.Drawing.Point(12, 36);
            this.txtBxNewPasswd.MaxLength = 50;
            this.txtBxNewPasswd.Name = "txtBxNewPasswd";
            this.txtBxNewPasswd.Size = new System.Drawing.Size(459, 22);
            this.txtBxNewPasswd.TabIndex = 1;
            this.txtBxNewPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttnGenerateNew
            // 
            this.bttnGenerateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGenerateNew.Location = new System.Drawing.Point(236, 121);
            this.bttnGenerateNew.Name = "bttnGenerateNew";
            this.bttnGenerateNew.Size = new System.Drawing.Size(236, 28);
            this.bttnGenerateNew.TabIndex = 3;
            this.bttnGenerateNew.Text = "Or Generate a new Password";
            this.bttnGenerateNew.UseVisualStyleBackColor = true;
            this.bttnGenerateNew.Click += new System.EventHandler(this.bttnGenerateNew_Click);
            // 
            // bttnSetPasswd
            // 
            this.bttnSetPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSetPasswd.Location = new System.Drawing.Point(12, 64);
            this.bttnSetPasswd.Name = "bttnSetPasswd";
            this.bttnSetPasswd.Size = new System.Drawing.Size(459, 35);
            this.bttnSetPasswd.TabIndex = 2;
            this.bttnSetPasswd.Text = "SET PASSWORD";
            this.bttnSetPasswd.UseVisualStyleBackColor = true;
            this.bttnSetPasswd.Click += new System.EventHandler(this.bttnSetPasswd_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bttnExit.Location = new System.Drawing.Point(12, 126);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 23);
            this.bttnExit.TabIndex = 4;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // PsswdChngrFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnSetPasswd);
            this.Controls.Add(this.bttnGenerateNew);
            this.Controls.Add(this.txtBxNewPasswd);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PsswdChngrFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxNewPasswd;
        private System.Windows.Forms.Button bttnGenerateNew;
        private System.Windows.Forms.Button bttnSetPasswd;
        private System.Windows.Forms.Button bttnExit;
    }
}