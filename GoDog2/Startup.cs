using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoDog2.Startup))]
namespace GoDog2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
