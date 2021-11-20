using BMB_assessment_Xamarin_APP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BMB_assessment_Xamarin_APP.Interfaces
{
    public interface IData
    {
        List<Order> GetOrders();
        Order GetOrder(int id);
        int SaveOrder(Order order);
        int SaveOrderList(List<Order> orders);
        int DeleteOrder(Order order);
    }
}
