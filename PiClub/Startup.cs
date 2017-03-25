using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PiClub.Startup))]
namespace PiClub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
