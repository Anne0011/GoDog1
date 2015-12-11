using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoDog.Startup))]
namespace GoDog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
