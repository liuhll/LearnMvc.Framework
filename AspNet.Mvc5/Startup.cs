using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNet.Mvc5.Startup))]
namespace AspNet.Mvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
