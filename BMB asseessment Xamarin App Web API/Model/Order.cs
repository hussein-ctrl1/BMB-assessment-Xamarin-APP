using System;


namespace BMB_asseessment_Xamarin_App_Web_API.Model
{
    public class Order
    {
        private int OrderId;
        private string OrderDate;
        private int OrderAmount;
        private string ClientDescription;
        private string Email;

        public Order() { }
        public Order(int orderId, string orderDate, int orderAmount, string clientDescription, string email)
        {
            OrderID = orderId;
            OrderDATE = orderDate;
            OrderAMOUNT = orderAmount;
            ClientDESCRIPTION = clientDescription;
            EMAIL = email;
        }

        public int OrderID { get => OrderId; set => OrderId = value; }
        public string OrderDATE { get => OrderDate; set => OrderDate = value; }
        public int OrderAMOUNT { get => OrderAmount; set => OrderAmount = value; }
        public string ClientDESCRIPTION { get => ClientDescription; set => ClientDescription = value; }
        public string EMAIL { get => Email; set => Email = value; }
    }
}
