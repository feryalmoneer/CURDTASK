using CURDTASK.data;
using CURDTASK.Model;

namespace CURDTASK
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ApplicationDbContext context = new ApplicationDbContext();
           
            Product product1 = new Product() {Name = "Laptop" , Price=230};
            Product product2 = new Product() { Name = "SmartPhone", Price = 3000 };
            Product product3 = new Product() { Name = "Tablet", Price = 230 };
            context.Products.Add(product1);
            context.Products.Add(product2);
            context.Products.Add(product3);
            context.SaveChanges();
            //Dispaly Data
            var dProduct = context.Products.ToList();
            foreach (var product in dProduct) Console.WriteLine(product.Name);
            //Upadte data
            var UProduct = context.Products.First(p => p.Id == 1);
            UProduct.Name = "Apple Watch";
            UProduct.Price = 2300;
            //Remove id=2
            var RProduct = context.Products.First(p => p.Id == 2);
            context.Products.Remove(RProduct);

           
            /*Order*/
            Order Order1 = new Order() { Address = "Tulkarm", createdAt = DateTime.Now };
            Order Order2 = new Order() { Address = "Nablus", createdAt = DateTime.Now };
            Order Order3 = new Order() { Address = "Jenin", createdAt = DateTime.Now };
            context.Orders.Add(Order1);
            context.Orders.Add(Order2);
            context.Orders.Add(Order3);


            context.SaveChanges();
            //Dispaly Data
            var dOrder = context.Orders.ToList();
            foreach (var order in dOrder) Console.WriteLine(order.Address);
            //Upadte data
            var UOrder = context.Orders.First(o => o.Id == 1);
            UOrder.Address = "Ramallh";
            context.SaveChanges();

            //Remove id=3
            var ROrder = context.Orders.First(o => o.Id == 3);
            context.Orders.Remove(ROrder);
            context.SaveChanges();

        }
    }
}
