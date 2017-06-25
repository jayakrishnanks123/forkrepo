using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(deploy1.Startup))]
namespace deploy1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
