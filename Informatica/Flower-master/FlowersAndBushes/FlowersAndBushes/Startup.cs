using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlowersAndBushes.Startup))]
namespace FlowersAndBushes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
