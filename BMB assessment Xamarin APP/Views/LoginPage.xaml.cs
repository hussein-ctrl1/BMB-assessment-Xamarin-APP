using BMB_assessment_Xamarin_APP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMB_assessment_Xamarin_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginPageVM LoginPageVM;
        public LoginPage()
        {
            InitializeComponent();
            LoginPageVM = new LoginPageVM();
            BindingContext = LoginPageVM;
        }
    }
}