using BMB_assessment_Xamarin_APP.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace BMB_assessment_Xamarin_APP.ViewModels
{
    public class HomePageVM
    {
        public HomePageVM(string Email)
        {
            this.Email = Email;
        }

        string email;
        public string Email
        {
            get { return email; }
            set => email = value;
        }

        HomePageFlyoutMenuItem homePageFlyoutMenuItem;

        public HomePageFlyoutMenuItem HomePageFlyoutMenuItem
        {
            get { return homePageFlyoutMenuItem; }
            set {
                homePageFlyoutMenuItem = value;
                NavigateToPage();
                }
        }

        private void NavigateToPage()
        {
            

        }

    }
}
