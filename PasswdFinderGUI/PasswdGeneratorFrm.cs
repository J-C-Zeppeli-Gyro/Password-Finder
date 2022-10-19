using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswdFinderGUI
{
    public partial class PasswdGeneratorFrm : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        void myNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trckBr.Value = Convert.ToInt32(nmrcUpDwn.Value);
        }
        public int PasswdLength
        {
            get 
            { 
                return Convert.ToInt32(nmrcUpDwn.Value);
            }
        }
        public string Passwd = string.Empty;

        void myTrackBar_ValueChanged(object sender, EventArgs e)
        {
            nmrcUpDwn.Value = trckBr.Value;
        }
        public PasswdGeneratorFrm()
        {
            InitializeComponent();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnGenerate_Click(object sender, EventArgs e)
        {
            Passwd = String.Empty;
            string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
            string upperCaseLetter = lowerCaseLetters.ToUpper();
            string numbers = "0123456789";
            string specialCharacters = "!@#$%^&*()+=~[:'<>?,.|";
            char[] _password = new char[PasswdLength];
            string usabelCharacters = string.Empty;
            Random rnd = new Random();

            if (chckBxLowerCC.Checked == false && chckBxUpperCC.Checked == false && chckBxNumbers.Checked == false && chckBxSpecial.Checked == false)
                MessageBox.Show("There is nothing checked for the password to be randomized!");
            else
            {
                if (chckBxLowerCC.Checked == true) usabelCharacters += lowerCaseLetters;
                if (chckBxUpperCC.Checked == true) usabelCharacters += upperCaseLetter;
                if (chckBxNumbers.Checked == true) usabelCharacters += numbers;
                if (chckBxSpecial.Checked == true) usabelCharacters += specialCharacters;

                for (int i = 0; i < PasswdLength; i++)
                {
                    _password[i] = usabelCharacters[rnd.Next(usabelCharacters.Length - 1)];
                    Passwd += _password[i];
                }
                txtBxPasswd.Text = Passwd;
                bttnDone.Enabled = true;
            }
        }

        private void bttnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
