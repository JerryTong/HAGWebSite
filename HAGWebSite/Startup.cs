using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HAGWebSite.Startup))]
namespace HAGWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
