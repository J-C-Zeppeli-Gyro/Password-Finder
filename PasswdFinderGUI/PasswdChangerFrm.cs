using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswdFinderGUI
{
    public partial class PsswdChngrFrm : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        public PsswdChngrFrm()
        {
            InitializeComponent();
        }
        public string Password = string.Empty;
        public bool wasChanged = false; 

        private void bttnSetPasswd_Click(object sender, EventArgs e)
        {
            Password = txtBxNewPasswd.Text;
            if (Password.Length > 9)
            {
                wasChanged = true;
                this.Close();
            }
            else
            {
                wasChanged = false;
                MessageBox.Show($"Please give it an another try, your password is too short ({Password})");
                txtBxNewPasswd.Text = string.Empty;
                Password = string.Empty;
                txtBxNewPasswd.Focus();
            }
        }

        private void bttnGenerateNew_Click(object sender, EventArgs e)
        {
            var PasswdGenFrm = new PasswdGeneratorFrm();
            PasswdGenFrm.ShowDialog();
            txtBxNewPasswd.Text = PasswdGenFrm.Passwd;
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
