using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRLConnect.Startup))]
namespace HRLConnect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
