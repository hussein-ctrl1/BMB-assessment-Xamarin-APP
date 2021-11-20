using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BMB_assessment_Xamarin_APP.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
