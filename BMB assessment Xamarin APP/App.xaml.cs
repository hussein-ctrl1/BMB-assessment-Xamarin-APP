using BMB_assessment_Xamarin_APP.Database;
using BMB_assessment_Xamarin_APP.Http;
using BMB_assessment_Xamarin_APP.Models;
using BMB_assessment_Xamarin_APP.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMB_assessment_Xamarin_APP
{
    public partial class App : Application
    {
        public static BMB_assessment_Xamarin_APP_DatabaseController BMB_Assessment_Xamarin_APP_DatabaseController;
        HttpFactory httpFactory;
        public App()
        {
            InitializeComponent();
            httpFactory = new HttpFactory();
            List<Order> orders = new List<Order>();
            orders = JsonConvert.DeserializeObject<List<Order>>(httpFactory.GetResponse().Result.ToString());
            App.BMB_Assessment_Xamarin_APP_DatabaseController.SaveOrderList(orders);
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
