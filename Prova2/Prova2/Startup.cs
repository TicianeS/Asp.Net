using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prova2.Startup))]
namespace Prova2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
