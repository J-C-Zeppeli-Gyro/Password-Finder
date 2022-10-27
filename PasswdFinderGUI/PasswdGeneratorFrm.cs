using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PasswdFinderGUI
{
    public partial class PasswdGeneratorFrm : Form
    {
        public PasswdGeneratorFrm()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        
        void myNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trckBr.Value = Convert.ToInt32(nmrcUpDwn.Value);
        }

        void myTrackBar_ValueChanged(object sender, EventArgs e)
        {
            nmrcUpDwn.Value = trckBr.Value;
        }
        
        public int PasswdLength
        {
            get 
            { 
                return Convert.ToInt32(nmrcUpDwn.Value);
            }
        }

        public string Passwd = string.Empty;

        private Color darkLighterBackColor = Color.FromArgb(32, 32, 32);
        private Color darkBackColor = Color.FromArgb(23, 23, 23);
        private Color White = Color.White;
        private Color Black = Color.Black;

        [DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
        public static extern bool ShouldSystemUseDarkMode();

        private void DarkMode()
        {
            ForeColor = White;
            BackColor = darkBackColor;
            foreach (Button bttn in this.Controls.OfType<Button>())
            {
                bttn.FlatStyle = FlatStyle.Flat;
                bttn.FlatAppearance.BorderColor = darkLighterBackColor;
                bttn.BackColor = darkLighterBackColor;
                bttn.ForeColor = White;
            }
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                tb.BackColor = darkLighterBackColor;
                tb.ForeColor = White;
            }
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = White;
            nmrcUpDwn.ForeColor = White;
            nmrcUpDwn.BackColor = darkLighterBackColor;
        }

        private void LightMode()
        {
            ForeColor = default;
            BackColor = default;
            foreach (Button bttn in this.Controls.OfType<Button>())
            {
                bttn.FlatStyle = FlatStyle.Standard;
                bttn.FlatAppearance.BorderColor = default;
                bttn.BackColor = default;
                bttn.ForeColor = default;
            }
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                tb.BackColor = default;
                tb.ForeColor = default;
            }
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = default;
            nmrcUpDwn.ForeColor = default;
            nmrcUpDwn.BackColor = default;
        }

        private void SystemDefaultMode()
        {
            if (ShouldSystemUseDarkMode()) DarkMode();
            else LightMode();
        }

        private void PasswdGeneratorFrm_Load(object sender, EventArgs e)
        {
            var main = new MainFrm();
            SystemDefaultMode();
            if (File.Exists(@"C:\Settings\UIsettings.txt"))
            {
                string[] UI = main.UI;
                UI = File.ReadAllLines(@"C:\Settings\UIsettings.txt");
                if (UI[0] == "Dark") DarkMode();
                else if (UI[0] == "Light") LightMode();
                else SystemDefaultMode();
            }
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Passwd = "";
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