using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gambling.Web.Startup))]
namespace Gambling.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
