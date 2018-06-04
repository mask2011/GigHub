using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHubChMask2011.Startup))]
namespace GigHubChMask2011
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
