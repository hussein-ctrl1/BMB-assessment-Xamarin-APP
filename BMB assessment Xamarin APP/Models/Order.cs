using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BMB_assessment_Xamarin_APP.Models
{
    [Table("Order")]
    public class Order
    {

        private int id;
        private string date;
        private string description;
        private string email;
        private int amount;

        [PrimaryKey,AutoIncrement]
        public int OrderId { get => id; set => id = value; }
        public string OrderDate { get => date; set => date = value; }
        public string ClientDescription { get => description; set => description = value; }
        public string Email { get => email; set => email = value; }
        public int OrderAmount { get => amount; set => amount = value; }

        public Order(int orderId, string orderDate, string clientDescription, string email, int orderAmount)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            ClientDescription = clientDescription;
            Email = email;
            OrderAmount = orderAmount;
        }

        public Order()
        {
        }
    }
}
