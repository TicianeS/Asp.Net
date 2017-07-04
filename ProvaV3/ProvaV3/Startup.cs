using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvaV3.Startup))]
namespace ProvaV3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
