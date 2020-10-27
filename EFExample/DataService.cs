using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.EntityFrameworkCore;

namespace Raw12_Assignment4_1
{
    public class DataService
    {
        //Order methods

        //1
        // fix Unable to determine the relationship represented by navigation property 'Order.OrderDetails' of type 'OrderDetails'.
        /*public IList<Order> GetSingleOrderById(int thisid)
        {
            using var ctx = new NorthWindContext();
            return ctx.Orders
                .Include(x => new
                {
                    x.OrderDetails,
                    x.Product,
                    x.Category
                })
                .Where(x => x.Id == thisid)
                .ToList();
        }*/

        //2
        //should be right but throws type error when called in program.cs
        /*public IList<Order> GetOrderByShipname(String ship)
        {
            using var ctx = new NorthWindContext();
            return (IList<Order>)ctx.Orders
                .Select(x => new
                {
                    x.Id,
                    x.Date,
                    x.ShipName,
                    x.ShipCity
                })
                .Where(x => x.ShipName == ship)
                .ToList();
        }*/

        //3
        // also some error
        public IList<Order> ListAllOrders()
        {
            using var ctx = new NorthWindContext();
            return (IList<Order>)ctx.Orders
                .Select(x => new
                {
                    x.OrderId,
                    x.Date,
                    x.ShipName,
                    x.ShipCity
                })
                .ToList();
        }
        //end Order methods


        // Order details methods

        //4
        // fix productname reference and is to be order id reference
        /*public IList<OrderDetails> GetDetailsForSpecificOrderId(int thisid)
        {
            using var ctx = new NorthWindContext();
            return (IList<OrderDetails>)ctx.OrderDetails
                .Include(x => new 
                { 
                    x.Product,
                    x.Order
                })
                .Select(x => new
                {
                    x.UnitPrice,
                    x.Quantity
                    //x.ProductName //fix so it selects productname from products
                })
                .Where(x => x.Id = thisid) //fix so its order id
                .ToList();
        }*/


        // end Order details methodss


    }
    
}