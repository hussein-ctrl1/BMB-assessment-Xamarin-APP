using BMB_asseessment_Xamarin_App_Web_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMB_asseessment_Xamarin_App_Web_API
{
    public class MockData
    {
        readonly List<Order> Orders= new List<Order>();
        public List<Order> GetOrders()
        {
            Orders.Add(new Order(1, new DateTime(2015, 12, 30).ToShortDateString(), 20, "Test Test Test", "fneishussein@gmail.com"));
            Orders.Add(new Order(2, new DateTime(2014, 11, 30).ToShortDateString(), 25, "Test Test Test Test", "fneishussein@gmail.com"));
            Orders.Add(new Order(3, new DateTime(2013, 10, 30).ToShortDateString(), 30, "Test Test Test Test Test", "fneishussein@gmail.com"));
            Orders.Add(new Order(4, new DateTime(2012, 9, 30).ToShortDateString(), 35, "Test Test Test Test Test Test", "fneishussein@gmail.com"));
            Orders.Add(new Order(5, new DateTime(2011, 8, 30).ToShortDateString(), 40, "Test Test Test Test Test Test Test", "fneishussein@gmail.com"));
            Orders.Add(new Order(6, new DateTime(2016, 7, 30).ToShortDateString(), 45, "Test Test Test Test Test Test Test Test", "fneishussein@gmail.com"));
            Orders.Add(new Order(7, new DateTime(2017, 6, 30).ToShortDateString(), 50, "Test Test Test Test Test Test Test Test Test", "201710884@ua.edu.lb"));
            Orders.Add(new Order(8, new DateTime(2018, 5, 30).ToShortDateString(), 55, "Test Test Test Test Test Test Test Test Test Test", "201710884@ua.edu.lb"));
            Orders.Add(new Order(9, new DateTime(2019, 4, 30).ToShortDateString(), 60, "Test Test Test Test Test Test Test Test Test Test Test", "201710884@ua.edu.lb"));
            Orders.Add(new Order(10, new DateTime(2021, 12, 29).ToShortDateString(), 65, "Test Test Test Test Test Test Test Test Test Test Test  Test", "201710884@ua.edu.lb"));
            Orders.Add(new Order(11, new DateTime(2022, 11, 29).ToShortDateString(), 65, "Test Test Test Test Test Test Test Test Test Test Test  Test Test", "test@gmail.com"));
            Orders.Add(new Order(12, new DateTime(2014, 10, 20).ToShortDateString(), 65, "Test Test Test Test Test Test Test Test Test Test Test  Test Test Test", "test@gmail.com"));
            Orders.Add(new Order(13, new DateTime(2015, 11, 21).ToShortDateString(), 65, "Test Test Test Test Test Test Test Test Test Test Test  Test Test Test Test", "test@gmail.com"));
            Orders.Add(new Order(14, new DateTime(2016, 3, 22).ToShortDateString(), 65, "Test Test Test Test Test Test Test Test Test Test Test  Test Test Test Test Test", "test@gmail.com"));
            return Orders;
        }
    }
}
