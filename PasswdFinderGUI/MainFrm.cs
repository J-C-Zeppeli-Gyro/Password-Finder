﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PasswdFinderGUI
{
    public partial class MainFrm : Form
    {
        private List<Input> passwds = new List<Input>();
        private string ActualPass = string.Empty;
        private string path = string.Empty;
        public string[] UI = { };

        private Color darkLighterBackColor = Color.FromArgb(32, 32, 32);
        private Color darkBackColor = Color.FromArgb(23, 23, 23);
        private Color White = Color.White;
        private Color Black = Color.Black;

        [DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
        public static extern bool ShouldSystemUseDarkMode();

        public MainFrm()
        {
            InitializeComponent();
        }

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
            txtBxForQuery.BackColor = darkLighterBackColor;
            txtBxForQuery.ForeColor = Color.White;
            lstBx.BackColor = darkLighterBackColor;
            lstBx.ForeColor = Color.White;
            lstVw.BackColor = darkLighterBackColor;
            lstVw.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            mnStrp.BackColor = darkLighterBackColor;
            mnStrp.ForeColor = Color.White;
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
            txtBxForQuery.BackColor = default;
            txtBxForQuery.ForeColor = default;
            lstBx.BackColor = default;
            lstBx.ForeColor = default;
            lstVw.BackColor = default;
            lstVw.ForeColor = default;
            label1.ForeColor = default;
            mnStrp.BackColor = default;
            mnStrp.ForeColor = default;
        }

        private void SystemDefaultMode()
        {
            if (ShouldSystemUseDarkMode()) DarkMode();
            else LightMode();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            bttnDroptxt.Enabled = false;
            bttnSearch.Enabled = false;
            txtBxForQuery.Enabled = false;
            bttnCopyLoginCred.Enabled = false;
            bttnCopyPasswd.Enabled = false;
            bttnOnlyAccount.Enabled = false;
            bttnChanger.Enabled = false;
            bttnListAllPrittyPrint.Enabled = false;
            lstBx.Enabled = false;
            bttnAddNew.Enabled = false;
            lstBx.Size = new Size(768, 576);
            lstVw.Size = new Size(0, 0);
            SystemDefaultMode();
            for (int i = 0; i < 2; i++)
            {
                if (File.Exists(@"C:\Settings\UIsettings.txt"))
                {
                    UI = File.ReadAllLines(@"C:\Settings\UIsettings.txt");
                    if (UI[0] == "Dark") DarkMode();
                    else if (UI[0] == "Light") LightMode();
                    else SystemDefaultMode();
                }
                else
                {
                    var dir = @"C:\Settings";
                    if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                    File.WriteAllText(Path.Combine(dir, "UIsettings.txt"), "System default");
                }
            }
            

        }

        private void LoadList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                foreach (var row in File.ReadAllLines(path).Skip(1))
                    passwds.Add(new Input(row));
                bttnDroptxt.Enabled = true;
                bttnSearch.Enabled = true;
                txtBxForQuery.Enabled = true;
                bttnOnlyAccount.Enabled = true;
                bttnListAllPrittyPrint.Enabled = true;
                bttnAddNew.Enabled = true;
                lstBx.Enabled = true;
                bttnLoad.Enabled = false;
                lstBx.Size = new Size(768, 576);
                lstVw.Size = new Size(0, 0);
            }
            else
                MessageBox.Show("Failed to load your text file!");
            
        }

        private void AccountList_Click(object sender, EventArgs e)
        {
            bttnChanger.Enabled = false;
            bttnCopyLoginCred.Enabled = false;
            bttnCopyPasswd.Enabled = false;
            bttnListAllPrittyPrint.Enabled = true;
            lstVw.Items.Clear();
            lstBx.Items.Clear();
            lstBx.Size = new Size(768, 576);
            lstVw.Size = new Size(0, 0);
            foreach (var item in passwds)
                lstBx.Items.Add(item.AppName);
        }

        private void bttnListAllPrittyPrint_Click(object sender, EventArgs e)
        {
            bttnChanger.Enabled = false;
            bttnCopyLoginCred.Enabled = false;
            bttnCopyPasswd.Enabled = false;
            lstVw.Clear();
            lstBx.Items.Clear();
            lstBx.Size = new Size(0, 0);
            lstVw.Size = new Size(768, 576);
            lstVw.View = View.Details;
            lstVw.Columns.Add("AppName");
            lstVw.Columns.Add("LoginNameSlashEmail");
            lstVw.Columns.Add("Password");
            lstVw.Columns.Add("RecoverySlash2FA");
            foreach (var item in passwds)
                lstVw.Items.Add(new ListViewItem(new string[] { item.AppName, item.LoginNameSlashEmail, item.Password, item.RecoverySlash2FA}));
            lstVw.GridLines = true;
            lstVw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            
        }

        public void Search_Click(object sender, EventArgs e)
        {
            bttnListAllPrittyPrint.Enabled = true;
            lstVw.Items.Clear();
            lstBx.Items.Clear();
            lstBx.Size = new Size(768, 576);
            lstVw.Size = new Size(0, 0);
            foreach (var item in passwds) //AppName's all letter to lower case
                item.AppName = item.AppName.ToLower();
            string appName = txtBxForQuery.Text.ToLower().ToString();
            var query = from q in passwds where q.AppName.Contains(appName) select q;
            if (appName == "")
            {
                lstBx.Items.Add($"There is nothing in the search bar!");
                bttnCopyLoginCred.Enabled = false;
                bttnCopyPasswd.Enabled = false;
            }
            else
            {
                if (query.Count() > 1)
                {
                    foreach (var item in query)
                    {
                        if (item.RecoverySlash2FA != "-")
                        {
                            lstBx.Items.Add($"Account:\t\t{item.AppName}");
                            lstBx.Items.Add($"\tEmail/LoginName:\t{item.LoginNameSlashEmail}");
                            lstBx.Items.Add($"\tPassword:\t{item.Password}");
                            lstBx.Items.Add($"\tRecovery:\t{item.RecoverySlash2FA}");
                        }
                        else
                        {
                            lstBx.Items.Add($"Account:\t\t{item.AppName}");
                            lstBx.Items.Add($"\tEmail/LoginName:\t{item.LoginNameSlashEmail}");
                            lstBx.Items.Add($"\tPassword:\t{item.Password}");
                        }
                    }
                    lstBx.Items.Add($"You can't copy your password, because there are multiple accounts for the keyword you searched for ({appName})!");
                    bttnCopyLoginCred.Enabled = false;
                    bttnCopyPasswd.Enabled = false;
                }
                else if (query.Count() == 1)
                {
                    bttnCopyLoginCred.Enabled = true;
                    bttnCopyPasswd.Enabled = true;
                    bttnChanger.Enabled = true;
                    ActualPass = query.FirstOrDefault().Password;
                    foreach (var item in query)
                    {
                        if (item.RecoverySlash2FA != "-")
                        {
                            lstBx.Items.Add($"Account:\t\t{item.AppName}");
                            lstBx.Items.Add($"\tEmail/LoginName:\t{item.LoginNameSlashEmail}");
                            lstBx.Items.Add($"\tPassword:\t{item.Password}");
                            lstBx.Items.Add($"\tRecovery:\t{item.RecoverySlash2FA}");
                        }
                        else
                        {
                            lstBx.Items.Add($"Account:\t\t{item.AppName}");
                            lstBx.Items.Add($"\tEmail/LoginName:\t{item.LoginNameSlashEmail}");
                            lstBx.Items.Add($"\tPassword:\t{item.Password}");
                        }
                    }
                }
                else
                {
                    lstBx.Items.Add($"There is nothing for the keyword: {appName}");
                    bttnCopyLoginCred.Enabled = false;
                    bttnCopyPasswd.Enabled = false;
                }
            }
        }

        private void bttnCopyLoginCred_Click(object sender, EventArgs e)
        {
            lstVw.Items.Clear();
            lstBx.Size = new Size(768, 576);
            lstVw.Size = new Size(0, 0);
            foreach (var item in passwds) //AppName's all letter to lower case
                item.AppName = item.AppName.ToLower();
            string appName = txtBxForQuery.Text.ToLower().ToString();
            var query = from q in passwds where q.AppName.Contains(appName) select q;
            Clipboard.SetText(query.FirstOrDefault().LoginNameSlashEmail.ToString());
            lstBx.Items.Add("");
            lstBx.Items.Add("Your login credential has been copied to the clipboard!");
        }

        private void bttnCopyPasswd_Click(object sender, EventArgs e)
        {
            lstVw.Items.Clear();
            lstBx.Size = new Size(768, 576);
            lstVw.Size = new Size(0, 0);
            foreach (var item in passwds) //AppName's all letter to lower case
                item.AppName = item.AppName.ToLower();
            string appName = txtBxForQuery.Text.ToLower().ToString();
            var query = from q in passwds where q.AppName.Contains(appName) select q;
            Clipboard.SetText(query.FirstOrDefault().Password.ToString());
            lstBx.Items.Add("");
            lstBx.Items.Add("Your password has been copied to the clipboard!");
        }

        private void bttnDroptxt_Click(object sender, EventArgs e)
        {
            lstBx.Size = new Size(768, 576);
            lstVw.Size = new Size(0, 0);
            passwds.Clear();
            bttnDroptxt.Enabled = false;
            bttnSearch.Enabled = false;
            txtBxForQuery.Enabled = false;
            bttnCopyLoginCred.Enabled = false;
            bttnCopyPasswd.Enabled = false;
            bttnOnlyAccount.Enabled = false;
            bttnChanger.Enabled = false;
            bttnListAllPrittyPrint.Enabled = false;
            bttnAddNew.Enabled = false;
            
            lstBx.Enabled = false;
            lstBx.Items.Clear();
            lstVw.Items.Clear();
            txtBxForQuery.Text = "";
            bttnLoad.Enabled = true;
        }

        private void bttnChanger_Click(object sender, EventArgs e)
        {
            var PwdChanger = new PsswdChngrFrm();
            PwdChanger.ShowDialog();
            if (PwdChanger.wasChanged)
            {
                DialogResult dialogResult = MessageBox.Show($"Do you really want to change your password\nFrom: {ActualPass}\nTo: {PwdChanger.Password}", "Confirmation of changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string strFile = File.ReadAllText(path);
                    strFile = Regex.Replace(strFile, ActualPass, PwdChanger.Password);
                    File.WriteAllText(path, strFile);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Password change failed");
                    PwdChanger.Password = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Password change failed");
                PwdChanger.Password = string.Empty;
            }

        }

        private void txtBxForQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bttnSearch.PerformClick();
        }

        private void bttnAddNew_Click(object sender, EventArgs e)
        {
            var addNew = new addNewFrm();
            addNew.ShowDialog();
            if (addNew.AppName != "")
            {
                StreamWriter sw = new StreamWriter(path, true);
                sw.Write($"\n{addNew.AppName};{addNew.LoginCredentials};{addNew.Password};{addNew.TwoFA}");
                sw.Close();
            }
        }

        private void MainFrm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MainFrm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filepaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                path = filepaths[0];
                foreach (var row in File.ReadAllLines(path).Skip(1))
                    passwds.Add(new Input(row));
                bttnDroptxt.Enabled = true;
                bttnSearch.Enabled = true;
                txtBxForQuery.Enabled = true;
                bttnOnlyAccount.Enabled = true;
                bttnListAllPrittyPrint.Enabled = true;
                bttnAddNew.Enabled = true;
                lstBx.Enabled = true;
                bttnLoad.Enabled = false;
                lstBx.Size = new Size(768, 576);
                lstVw.Size = new Size(0, 0);
            }
            else
                MessageBox.Show("Failed to load your text file!");
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarkMode();
            StreamWriter sw = new StreamWriter(@"C:\Settings\UIsettings.txt");
            sw.WriteLine("Dark");
            sw.Close();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LightMode();
            StreamWriter sw = new StreamWriter(@"C:\Settings\UIsettings.txt");
            sw.WriteLine("Light");
            sw.Close();
        }

        private void systemDefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemDefaultMode();
            StreamWriter sw = new StreamWriter(@"C:\Settings\UIsettings.txt");
            sw.WriteLine("System Default");
            sw.Close();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created after my facebook got hacked and I forced to store my password in a text file." +
                "\n\nCreated by: Debreceni Norbert (18), Hungarian student at Dunaújváros, Rudas");
        }

    }
}
