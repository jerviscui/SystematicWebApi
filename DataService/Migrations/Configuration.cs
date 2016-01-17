using System.Collections.Generic;
using Domain.Entity;

namespace DataService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataService.EfDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataService.EfDbContext context)
        {
            context.Table<Product>().AddOrUpdate(product => product.Name, new Product[]
            {
                new Product() { Name = "001", Category = "C1", Price = 15 },
                new Product() { Name = "002", Category = "C2", Price = 10 },
                new Product() { Name = "jingjing", Category = "Love", Price = int.MaxValue },
                new Product() { Name = "apple", Category = "C3", Price = (decimal) 5.5 },
            });
            context.SaveChanges();

            context.Table<Order>().AddOrUpdate(order => order.Id, new Order()
            {
                Customer = "test",
                Id = 1,
                OrderDetails = new List<OrderDetail>()
                {
                    new OrderDetail() { Product = context.Table<Product>().First(o => o.Name == "001"), Quantity = 2 },
                    new OrderDetail() { Product = context.Table<Product>().First(o => o.Name.Equals("002")), Quantity = 5 },
                    new OrderDetail() { Product = context.Table<Product>().First(o => o.Name.Equals("jingjing")), Quantity = 1 }
                }
            });
        }
    }
}
