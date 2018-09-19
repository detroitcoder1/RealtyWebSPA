using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealtyWebApp.Startup))]
namespace RealtyWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
