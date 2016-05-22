using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PVEHackathon.Startup))]
namespace PVEHackathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
