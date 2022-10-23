using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;

namespace passwds
{
    internal class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int MAXIMIZE = 3;
        [STAThread]
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
            List<Input> PasswdFile = new List<Input>();
            foreach (var row in File.ReadAllLines("[your_passwd_file].txt").Skip(1)) //Paste your password file to bin/Debug and replace [your_passwd_file] with the the of the passwd file
                PasswdFile.Add(new Input(row));
            foreach (var item in PasswdFile) //AppName's all letter to lower case
                item.AppName = item.AppName.ToLower();
            string appName = string.Empty;
            string Searched = string.Empty;
            do
            {
                Console.Clear();
                Console.Write("Which account should I get an email and password for?(Keyword is enough) ");
                appName = Console.ReadLine().ToLower();
                var searchForWhileLoop = (from s in PasswdFile where s.AppName.Contains(appName) select s);
                if (searchForWhileLoop.Count() != 0)
                    Searched = searchForWhileLoop.FirstOrDefault().AppName.ToString();
                else
                {
                    Console.WriteLine("We can't find what you are looking for, try again in 3 seconds!");
                    Thread.Sleep(3000);
                    Searched = string.Empty;
                }
            } while (!Searched.Contains(appName));
            var Search = from s in PasswdFile where s.AppName.Contains(appName) select s;
            Thread.Sleep(2000);
            Console.Clear();
            if (Search.Count() > 1)
            {
                foreach (var item in Search)
                {
                    if (item.RecoverySlash2FA != "-")
                        Console.WriteLine($"\tAccount:\t\t{item.AppName}\n\tEmail/LoginName:\t{item.LoginNameSlashEmail}\n\tPassword:\t\t{item.Password}\n\tRecovery/2FA:\t\t{item.RecoverySlash2FA}\n");
                    else
                        Console.WriteLine($"\tAccount:\t\t{item.AppName}\n\tEmail/LoginName:\t{item.LoginNameSlashEmail}\n\tPassword:\t\t{item.Password}\n");
                }
                Console.WriteLine($"We can't copy your password, because there are multiple accounts for the keyword you searched for ({appName})!");
            }
            else
            {
                foreach (var item in Search)
                {
                    if (item.RecoverySlash2FA != "-")
                        Console.WriteLine($"\tAccount:\t\t{item.AppName}\n\tEmail/LoginName:\t{item.LoginNameSlashEmail}\n\tPassword:\t\t{item.Password}\n\tRecovery/2FA:\t\t{item.RecoverySlash2FA}\n");
                    else
                        Console.WriteLine($"\tAccount:\t\t{item.AppName}\n\tEmail/LoginName:\t{item.LoginNameSlashEmail}\n\tPassword:\t\t{item.Password}\n");
                    Clipboard.SetText(item.LoginNameSlashEmail);
                    Console.WriteLine($"We copied you Login credentials to the clipboard!\n\tYou have 10 seconds to fill in your Login on {item.AppName}'s page/app until we copy your password to the clipboard");
                    Thread.Sleep(10000);
                    Clipboard.SetText(item.Password);
                    Console.WriteLine("We copied you password to the clipboard!");
                }
            }
            Thread.Sleep(5000);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}