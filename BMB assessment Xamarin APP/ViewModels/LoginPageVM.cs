using BMB_assessment_Xamarin_APP.Views;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace BMB_assessment_Xamarin_APP.ViewModels
{
    class LoginPageVM:INotifyPropertyChanged
    {

        private LoginServiceClient LoginServiceClient=new LoginServiceClient();
        public event PropertyChangedEventHandler PropertyChanged;
        private string email = string.Empty;
        private string password = string.Empty;
        private readonly Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public string Email
        {
            get { return email; }
            set
            {
                if (email == value)
                    return;

                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (password == value)
                    return;

                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public Command LoginCommand
        {
            get
            {
                return new Command(() =>
                {
                    Login();
                });
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
                return;
            }
            if (!ValidateEmail(Email))
            {
                await Application.Current.MainPage.DisplayAlert("Email is Not Correct", "Please enter Email Correctly", "OK");
                return;
            }
            if (LoginServiceClient.IsAuthenticatedUser(new IsAuthenticatedUserRequest(Email, Password)).IsAuthenticatedUserResult) {
                await Application.Current.MainPage.DisplayAlert("Login Success", "", "Ok");
                HomePage home = new HomePage(Email);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
            }
        }

        public bool ValidateEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && EmailRegex.IsMatch(email);
        }

    }
}
