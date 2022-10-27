using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PasswdFinderGUI
{
    public partial class PsswdChngrFrm : Form
    {
        public PsswdChngrFrm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        
        public string Password = string.Empty;
        public bool wasChanged = false;

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
        }

        private void SystemDefaultMode()
        {
            if (ShouldSystemUseDarkMode()) DarkMode();
            else LightMode();
        }

        private void PsswdChngrFrm_Load(object sender, EventArgs e)
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

        private void txtBxNewPasswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bttnSetPasswd.PerformClick();
        }

    }
}
