using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Informatica.Startup))]
namespace Informatica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
