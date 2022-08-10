using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThirdXmEve.Startup))]
namespace ThirdXmEve
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
