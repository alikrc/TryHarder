using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryHarder.Web.Startup))]
namespace TryHarder.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
