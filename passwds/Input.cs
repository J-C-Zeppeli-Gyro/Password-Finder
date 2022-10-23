namespace passwds
{
    internal class Input
    {
        public string AppName { get; set; }
        public string LoginNameSlashEmail { get; set; }
        public string Password { get; set; }
        public string RecoverySlash2FA { get; set; }

        public Input(string row)
        {
            string[] s = row.Split(';');
            AppName = s[0];
            LoginNameSlashEmail = s[1];
            Password = s[2];
            RecoverySlash2FA = s[3];
        }
    }
}