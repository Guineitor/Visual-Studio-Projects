using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Affogato.Startup))]
namespace Affogato
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
