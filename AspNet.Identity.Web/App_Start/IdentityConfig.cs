using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNet.Identity.Web.Db.AppIdentityDb;
using AspNet.Identity.Web.Models.UsersManagement;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace AspNet.Identity.Web
{
    /// </summary>
    public class AppUserManager : UserManager<AppUser>
    {

        public AppUserManager(IUserStore<AppUser> store)
            : base(store)
        {
        }

        public static AppUserManager Create(
                IdentityFactoryOptions<AppUserManager> options,
                IOwinContext context)
        {

            AppIdentityDbContext db = context.Get<AppIdentityDbContext>();
            //UserStore<T> 是 包含在 Microsoft.AspNet.Identity.EntityFramework 中，它实现了 UserManger 类中与用户操作相关的方法。
            //也就是说UserStore<T>类中的方法（诸如：FindById、FindByNameAsync...）通过EntityFramework检索和持久化UserInfo到数据库中
            AppUserManager manager = new AppUserManager(new UserStore<AppUser>(db));

            return manager;
        }
    }
}