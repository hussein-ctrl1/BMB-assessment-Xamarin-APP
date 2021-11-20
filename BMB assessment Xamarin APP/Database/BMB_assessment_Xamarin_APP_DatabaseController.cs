using BMB_assessment_Xamarin_APP.Interfaces;
using BMB_assessment_Xamarin_APP.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace BMB_assessment_Xamarin_APP.Database
{
    public class BMB_assessment_Xamarin_APP_DatabaseController : IData
    {
        static object locker = new object();

        SQLiteConnection databaseConnection;

        public BMB_assessment_Xamarin_APP_DatabaseController()
        {
            databaseConnection = DependencyService.Get<ISQLite>().GetConnection();
            _ = databaseConnection.CreateTable<Order>();
        }

        public List<Order> GetOrders()
        {
            lock (locker)
            {
                return databaseConnection.Table<Order>().ToList();
            }
        }

        public List<Order> GetOrdersByEmail(string email)
        {
            lock (locker)
            {
                return databaseConnection.Table<Order>().Where(obj=>obj.Email==email).ToList();
            }
        }

        public Order GetOrder(int id)
        {
            lock (locker)
            {
                return databaseConnection.Table<Order>().Where(obj => obj.OrderId == id).FirstOrDefault();
            }
        }

        public int SaveOrder(Order order)
        {
            lock (locker)
            {
                if (order.OrderId != 0)
                {
                    return databaseConnection.Update(order);
                }
                else
                {
                    return databaseConnection.Insert(order);
                }
            }
        }

        public int SaveOrderList(List<Order> orders)
        {
            lock (locker)
            {
                return databaseConnection.InsertAll(orders);
            }
        }

        public int DeleteOrder(Order order)
        {
            lock (locker)
            {
                return databaseConnection.Delete(order);
            }
        }
    }
}
