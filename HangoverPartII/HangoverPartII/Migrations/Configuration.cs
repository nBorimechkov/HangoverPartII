namespace HangoverPartII.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //    if (!context.Users.Any())
            //    {
            //        // If the database is empty, populate sample data in it

            //        CreateUser(context, "admin","admin@gmail.com", "123", "System Administrator");
            //        CreateUser(context, "pesho", "pesho@gmail.com", "123", "Peter Ivanov");
            //        CreateUser(context, "merry", "merry@gmail.com", "123", "Maria Petrova");
            //        CreateUser(context, "geshu", "geshu@gmail.com", "123", "George Petrov");

            //        CreateRole(context, "Administrators");
            //        AddUserToRole(context, "admin", "Administrators");

            //        context.SaveChanges();
            //    }
            //}

            //private void CreateUser(ApplicationDbContext context, string username,
            //    string email, string password, string fullName)
            //{
            //    var userManager = new UserManager<ApplicationUser>(
            //        new UserStore<ApplicationUser>(context));
            //    userManager.PasswordValidator = new PasswordValidator
            //    {
            //        RequiredLength = 3,
            //        RequireNonLetterOrDigit = false,
            //        RequireDigit = false,
            //        RequireLowercase = false,
            //        RequireUppercase = false,
            //    };

            //    var user = new ApplicationUser
            //    {
            //        UserName = username,
            //        Email = email,
            //        FullName = fullName
            //    };

            //    var userCreateResult = userManager.Create(user, password);
            //    if (!userCreateResult.Succeeded)
            //    {
            //        throw new Exception(string.Join("; ", userCreateResult.Errors));
            //    }
            //}

            //private void CreateRole(ApplicationDbContext context, string roleName)
            //{
            //    var roleManager = new RoleManager<IdentityRole>(
            //        new RoleStore<IdentityRole>(context));
            //    var roleCreateResult = roleManager.Create(new IdentityRole(roleName));
            //    if (!roleCreateResult.Succeeded)
            //    {
            //        throw new Exception(string.Join("; ", roleCreateResult.Errors));
            //    }
            //}

            //private void AddUserToRole(ApplicationDbContext context, string userName, string roleName)
            //{
            //    var user = context.Users.First(u => u.UserName == userName);
            //    var userManager = new UserManager<ApplicationUser>(
            //        new UserStore<ApplicationUser>(context));
            //    var addAdminRoleResult = userManager.AddToRole(user.Id, roleName);
            //    if (!addAdminRoleResult.Succeeded)
            //    {
            //        throw new Exception(string.Join("; ", addAdminRoleResult.Errors));
            //    }
        }
    }
}
