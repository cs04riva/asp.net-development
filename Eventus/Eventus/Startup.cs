using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eventus.Startup))]
namespace Eventus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
