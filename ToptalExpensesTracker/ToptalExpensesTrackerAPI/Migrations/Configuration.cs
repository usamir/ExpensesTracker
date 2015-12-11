namespace ToptalExpensesTrackerAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ToptalExpensesTrackerAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ToptalExpensesTrackerAPI.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToptalExpensesTrackerAPI.Models.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new AppDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new AppDbContext()));

            var user = new ToptalExpensesTrackerAPI.Models.ApplicationUser()
            {
                UserName = "Administrator",
                Email = "samir@example.com",
                EmailConfirmed = true,
                FirstName = "Samir",
                LastName = "Uzunovic"
            };

            manager.Create(user, "MySuperP@ssword!");

            IdentityRole Admin = new IdentityRole { Name = "Admin" };
            // creating roles
            if (roleManager.Roles.Count() == 0)
            {
                roleManager.Create(Admin);
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            // assign SuperPowerUser to roles and Admin
            var adminUser = manager.FindByName("Administrator");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin" });
        }
    }
}
