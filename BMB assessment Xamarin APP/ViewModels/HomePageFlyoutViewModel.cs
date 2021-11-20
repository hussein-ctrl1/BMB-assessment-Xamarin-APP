using BMB_assessment_Xamarin_APP.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BMB_assessment_Xamarin_APP.ViewModels
{
    public class HomePageFlyoutViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<HomePageFlyoutMenuItem> MenuItems { get; set; }

        public HomePageFlyoutViewModel()
        {
            MenuItems = new ObservableCollection<HomePageFlyoutMenuItem>(new[]
            {
                    new HomePageFlyoutMenuItem { Id = 0, Title = "Order Listing" ,},
                    new HomePageFlyoutMenuItem { Id = 1, Title = "Order Definition" }
                });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion
    }
}
