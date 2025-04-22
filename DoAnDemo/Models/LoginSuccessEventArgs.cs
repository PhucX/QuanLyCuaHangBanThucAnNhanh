using System;

namespace DoAnDemo.Models
{
    public class LoginSuccessEventArgs : EventArgs
    {
        public string UserRole { get; }

        public LoginSuccessEventArgs(string role)
        {
            UserRole = role;
        }
    }
}