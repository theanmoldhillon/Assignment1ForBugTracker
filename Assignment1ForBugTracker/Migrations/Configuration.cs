namespace Assignment1ForBugTracker.Migrations
{
    using Assignment1ForBugTracker.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment1ForBugTracker.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assignment1ForBugTracker.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            //context.Customers.AddOrUpdate(x => x.Id,
            //  new Models.Customer() { Id = 1, Name = "Harsh", Email = "abcd@gmail.com" });

            //context.Products.AddOrUpdate(x => x.Id,
            //  new Models.Product() { Id = 1, Name = "Harsh", Quantity = 1, Price = 20 });

            //context.Employees.AddOrUpdate(x => x.Id,
            //  new Models.Employee() { Id = 1, Name = "Harsh", RegistrationNumber = 1 });




            context.SaveChanges();
        }
    }
}
