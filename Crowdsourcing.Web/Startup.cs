using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crowdsourcing.Web.Startup))]
namespace Crowdsourcing.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
