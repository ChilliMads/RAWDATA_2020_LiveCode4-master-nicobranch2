
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Raw12_Assignment4_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var dataService = new DataService();

            //order

            // 1 get single order by id
            // fix Unable to determine the relationship represented by navigation property 'Order.OrderDetails' of type 'OrderDetails'.
            //var id = 10500; //select Id
            /*foreach (var item in dataService.GetSingleOrderById(id))
            {
                Console.WriteLine(item);
            }*/

            // 2 get order by shipping name
            // fix System.InvalidCastException: Unable to cast object of type 
            /*var name = "Ernst Handel"; //select ship name
            foreach (var elem in dataService.GetOrderByShipname(name))
            {
                Console.WriteLine(elem);
            }*/

            // 3 list all orders
            // fix System.InvalidCastException: Unable to cast object of type
            /*foreach (var elem in dataService.ListAllOrders())
            {
                Console.WriteLine(elem);
            }*/

            //order end

            // order details 

            //4 get the details for a specific order ID
            /*var specId = 10500;
            foreach (var elem in dataService.GetDetailsForSpecificOrderId(specId))
            {
                Console.WriteLine(elem);
            }*/

            // order details end

            // testing foreach
            /*  foreach (var item in dataService.GetCategories())
              {
                  Console.WriteLine(item);
              }*/


            // henrik examples 
            //using var ctx = new NorthWindContext();

            //foreach (var product in ctx.Products.Include(x => x.Category))
            //{
            //    Console.WriteLine(product);
            //}

            //var cat = ctx.Categories.Find(9);

            //ctx.Categories.Remove(cat);

            ////cat.Name = "UpdateTest";
            ////cat.Description = "fdsjfsldkjfsdlkf";

            ////var maxId = ctx.Categories.Max(x => x.Id);

            ////ctx.Categories.Add(new Category {Id = maxId + 1, Name = "Testing"});

            //ctx.SaveChanges();

            //foreach (var category in ctx.Categories)
            //{
            //    Console.WriteLine(category);
            //}
            // henrik examples end

            //6 
            foreach (var elem in dataService.GetSinglePorductByID(1))
            {
                Console.WriteLine(elem);
            }
        }
    }
}
