namespace PasswdFinderGUI
{
    partial class PasswdGeneratorFrm
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
            this.nmrcUpDwn = new System.Windows.Forms.NumericUpDown();
            this.trckBr = new System.Windows.Forms.TrackBar();
            this.bttnGenerate = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.txtBxPasswd = new System.Windows.Forms.TextBox();
            this.chckBxNumbers = new System.Windows.Forms.CheckBox();
            this.chckBxLowerCC = new System.Windows.Forms.CheckBox();
            this.chckBxUpperCC = new System.Windows.Forms.CheckBox();
            this.chckBxSpecial = new System.Windows.Forms.CheckBox();
            this.bttnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBr)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrcUpDwn
            // 
            this.nmrcUpDwn.Location = new System.Drawing.Point(12, 9);
            this.nmrcUpDwn.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrcUpDwn.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrcUpDwn.Name = "nmrcUpDwn";
            this.nmrcUpDwn.Size = new System.Drawing.Size(136, 20);
            this.nmrcUpDwn.TabIndex = 0;
            this.nmrcUpDwn.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrcUpDwn.ValueChanged += new System.EventHandler(this.myNumericUpDown_ValueChanged);
            // 
            // trckBr
            // 
            this.trckBr.Location = new System.Drawing.Point(154, 8);
            this.trckBr.Maximum = 50;
            this.trckBr.Minimum = 10;
            this.trckBr.Name = "trckBr";
            this.trckBr.Size = new System.Drawing.Size(317, 45);
            this.trckBr.TabIndex = 2;
            this.trckBr.TickFrequency = 5;
            this.trckBr.Value = 10;
            this.trckBr.ValueChanged += new System.EventHandler(this.myTrackBar_ValueChanged);
            // 
            // bttnGenerate
            // 
            this.bttnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGenerate.Location = new System.Drawing.Point(152, 59);
            this.bttnGenerate.Name = "bttnGenerate";
            this.bttnGenerate.Size = new System.Drawing.Size(319, 64);
            this.bttnGenerate.TabIndex = 3;
            this.bttnGenerate.Text = "Generate Password";
            this.bttnGenerate.UseVisualStyleBackColor = true;
            this.bttnGenerate.Click += new System.EventHandler(this.bttnGenerate_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(12, 170);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 4;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // txtBxPasswd
            // 
            this.txtBxPasswd.Enabled = false;
            this.txtBxPasswd.Location = new System.Drawing.Point(12, 133);
            this.txtBxPasswd.MaxLength = 50;
            this.txtBxPasswd.Name = "txtBxPasswd";
            this.txtBxPasswd.Size = new System.Drawing.Size(459, 20);
            this.txtBxPasswd.TabIndex = 5;
            this.txtBxPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chckBxNumbers
            // 
            this.chckBxNumbers.AutoSize = true;
            this.chckBxNumbers.Location = new System.Drawing.Point(13, 40);
            this.chckBxNumbers.Name = "chckBxNumbers";
            this.chckBxNumbers.Size = new System.Drawing.Size(68, 17);
            this.chckBxNumbers.TabIndex = 6;
            this.chckBxNumbers.Text = "Numbers";
            this.chckBxNumbers.UseVisualStyleBackColor = true;
            // 
            // chckBxLowerCC
            // 
            this.chckBxLowerCC.AutoSize = true;
            this.chckBxLowerCC.Location = new System.Drawing.Point(13, 64);
            this.chckBxLowerCC.Name = "chckBxLowerCC";
            this.chckBxLowerCC.Size = new System.Drawing.Size(117, 17);
            this.chckBxLowerCC.TabIndex = 7;
            this.chckBxLowerCC.Text = "Lower Case Letters";
            this.chckBxLowerCC.UseVisualStyleBackColor = true;
            // 
            // chckBxUpperCC
            // 
            this.chckBxUpperCC.AutoSize = true;
            this.chckBxUpperCC.Location = new System.Drawing.Point(13, 87);
            this.chckBxUpperCC.Name = "chckBxUpperCC";
            this.chckBxUpperCC.Size = new System.Drawing.Size(117, 17);
            this.chckBxUpperCC.TabIndex = 8;
            this.chckBxUpperCC.Text = "Upper Case Letters";
            this.chckBxUpperCC.UseVisualStyleBackColor = true;
            // 
            // chckBxSpecial
            // 
            this.chckBxSpecial.AutoSize = true;
            this.chckBxSpecial.Location = new System.Drawing.Point(12, 110);
            this.chckBxSpecial.Name = "chckBxSpecial";
            this.chckBxSpecial.Size = new System.Drawing.Size(115, 17);
            this.chckBxSpecial.TabIndex = 9;
            this.chckBxSpecial.Text = "Special Characters";
            this.chckBxSpecial.UseVisualStyleBackColor = true;
            // 
            // bttnDone
            // 
            this.bttnDone.Enabled = false;
            this.bttnDone.Location = new System.Drawing.Point(398, 170);
            this.bttnDone.Name = "bttnDone";
            this.bttnDone.Size = new System.Drawing.Size(75, 23);
            this.bttnDone.TabIndex = 10;
            this.bttnDone.Text = "Done";
            this.bttnDone.UseVisualStyleBackColor = true;
            this.bttnDone.Click += new System.EventHandler(this.bttnDone_Click);
            // 
            // PasswdGeneratorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 205);
            this.Controls.Add(this.bttnDone);
            this.Controls.Add(this.chckBxSpecial);
            this.Controls.Add(this.chckBxUpperCC);
            this.Controls.Add(this.chckBxLowerCC);
            this.Controls.Add(this.chckBxNumbers);
            this.Controls.Add(this.txtBxPasswd);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnGenerate);
            this.Controls.Add(this.trckBr);
            this.Controls.Add(this.nmrcUpDwn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswdGeneratorFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrcUpDwn;
        private System.Windows.Forms.TrackBar trckBr;
        private System.Windows.Forms.Button bttnGenerate;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.TextBox txtBxPasswd;
        private System.Windows.Forms.CheckBox chckBxNumbers;
        private System.Windows.Forms.CheckBox chckBxLowerCC;
        private System.Windows.Forms.CheckBox chckBxUpperCC;
        private System.Windows.Forms.CheckBox chckBxSpecial;
        private System.Windows.Forms.Button bttnDone;
    }
}