using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OTS.Web.Startup))]
namespace OTS.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
