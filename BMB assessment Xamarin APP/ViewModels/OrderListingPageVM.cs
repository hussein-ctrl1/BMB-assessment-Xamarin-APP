using BMB_assessment_Xamarin_APP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BMB_assessment_Xamarin_APP.ViewModels
{
    class OrderListingPageVM
    {
        public List<Order> Orders { get; set; }
        public OrderListingPageVM(String Email)
        {
            this.Email = Email;
            Orders = App.BMB_Assessment_Xamarin_APP_DatabaseController.GetOrdersByEmail(Email);
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
