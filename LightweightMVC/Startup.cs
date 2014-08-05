using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LightweightMVC.Startup))]
namespace LightweightMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
