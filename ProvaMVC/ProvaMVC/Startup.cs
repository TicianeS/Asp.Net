using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvaMVC.Startup))]
namespace ProvaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
