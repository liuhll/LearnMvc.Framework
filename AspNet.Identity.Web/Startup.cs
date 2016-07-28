using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AspNet.Identity.Web.Startup))]
namespace AspNet.Identity.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}