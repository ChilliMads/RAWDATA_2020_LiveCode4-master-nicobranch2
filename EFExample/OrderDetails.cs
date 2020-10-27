using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw12_Assignment4_1
{
    public class OrderDetails
    {
        // properties
        public Double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

        // navigation

        public int OrderId { get; set; }
        public Order Order { get; set; }

        //public Product Product { get;  set; }

        /*public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }*/
    }
}
