using BMB_assessment_Xamarin_APP.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMB_assessment_Xamarin_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderListingPage : ContentPage
    {
        OrderListingPageVM OrderListingPageVM;
        public OrderListingPage(string Email)
        {
            InitializeComponent();
            OrderListingPageVM = new OrderListingPageVM(Email);
            BindingContext = OrderListingPageVM;

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        public static implicit operator Type(OrderListingPage v)
        {
            throw new NotImplementedException();
        }
    }
}
