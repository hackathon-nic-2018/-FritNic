using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FritNic.Startup))]
namespace FritNic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
