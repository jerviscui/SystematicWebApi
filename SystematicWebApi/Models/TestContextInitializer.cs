using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Domain.Entity;

namespace SystematicWebApi.Models
{
    public class TestContextInitializer : DropCreateDatabaseIfModelChanges<TestContext>
    {
        /// <summary>
        /// A method that should be overridden to actually add data to the context for seeding.
        ///             The default implementation does nothing.
        /// </summary>
        /// <param name="context">The context to seed. </param>
        protected override void Seed(TestContext context)
        {
            context.Products.AddRange(new List<Product>()
            {
                new Product() { Name = "001", Category = "C1", Price = 15 },
                new Product() { Name = "002", Category = "C2", Price = 10 },
                new Product() { Name = "jingjing", Category = "Love", Price = int.MaxValue },
                new Product() { Name = "apple", Category = "C3", Price = (decimal) 5.5 },
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}