using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using SQLite;
using BMB_assessment_Xamarin_APP.Droid.Database;
using System.IO;
using BMB_assessment_Xamarin_APP.Interfaces;

[assembly: Dependency(typeof(SqLiteConnection))]
namespace BMB_assessment_Xamarin_APP.Droid.Database
{
    public class SqLiteConnection : ISQLite
    {
        public SqLiteConnection() { }
        public SQLiteConnection GetConnection()
        {
            string fileName = "BMB_assessment_Xamarin_APP_Database.db3";
            string documentPath = GetExternalStorage();
            string path = Path.Combine(documentPath, fileName);
            SQLiteConnection connection = new SQLiteConnection(path);
            return connection;
        }
        public string GetExternalStorage()
        {
            Context context = Android.App.Application.Context;
            Java.IO.File filePath = context.GetExternalFilesDir("");
            return filePath.Path;
        }
    }
}