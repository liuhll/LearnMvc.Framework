using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNet.Identity.Web.Models.UsersManagement;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AspNet.Identity.Web.Db.AppIdentityDb
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {

        static AppIdentityDbContext()
        {
            //Database.SetInitializer<AppIdentityDbContext>(new IdentityDbInit());
            System.Data.Entity.Database.SetInitializer(new IdentityDbInit());
        }

        public AppIdentityDbContext()
            : base("DefaultConnection")
        {
        }

        public static AppIdentityDbContext Create()
        {
            return new AppIdentityDbContext();
        }
    }
}