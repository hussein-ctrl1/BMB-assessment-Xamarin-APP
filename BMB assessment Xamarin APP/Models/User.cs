using System;
using System.Collections.Generic;
using System.Text;

namespace BMB_assessment_Xamarin_APP.Models
{
    public class User
    {
        private string Email { get; set; }
        private string Password { get; set; }

        public User(){ }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
