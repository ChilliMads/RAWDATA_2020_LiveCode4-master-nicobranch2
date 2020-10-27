using System;
namespace Raw12_Assignment4_1
{
    public class Order
    {
        // properties
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Require { get; set; }
        public DateTime Shipped { get; set; }
        public string Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }

        // navigation
        //public OrderDetails OrderDetails { get; set; }


        
        //public Product Product { get; set; }
        //public Category Category { get; set; }

        //toString method
        /*public override string ToString()
        {
            return $"UnitPrice = {OrderDetails.UnitPrice}, Quantity = {OrderDetails.Quantity}, Discount = {OrderDetails.Discount},";
        }*/
    }
}
