using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgendaMVC.Startup))]
namespace AgendaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
