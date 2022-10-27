using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PasswdFinderGUI
{
    public partial class addNewFrm : Form
    { 
        public addNewFrm()
        {
            InitializeComponent();
        }
        
        public string AppName = string.Empty;
        public string LoginCredentials = string.Empty;
        public string Password = string.Empty;
        public string TwoFA = string.Empty;

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

        private void addNewFrm_Load(object sender, EventArgs e)
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

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            AppName = string.Empty;
            LoginCredentials = string.Empty;
            Password = string.Empty;
            TwoFA = string.Empty;
            this.Close();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            string notFilled = "Something isn't filled properly";
            AppName = txtBxAppName.Text;
            LoginCredentials = txtBxLogin.Text;
            Password = txtBxPass.Text;
            if (txtBx2FA.Text == "" || txtBx2FA.Text == "-")
                TwoFA = "-";
            else
                TwoFA = txtBx2FA.Text;

            string[] missing = { AppName, LoginCredentials, Password };
            if (missing[0] == "")
                notFilled += ", App Name";
            if (missing[1] == "")
                notFilled += ", Login Cred";
            if (missing[2] == "")
                notFilled += ", Password";

            if (notFilled == "Something isn't filled properly")
            {
                DialogResult DR = MessageBox.Show($"Double check your information" +
                $"\nApp Name: {AppName}" +
                $"\nLogin Credentials: {LoginCredentials}" +
                $"\nPassword: {Password}" +
                $"\n2FA: {TwoFA}",
                "Confirmation of new", MessageBoxButtons.YesNo);

                if (DR == DialogResult.Yes)
                    this.Close();
            }
            else
                MessageBox.Show(notFilled);


        }

    }
}
