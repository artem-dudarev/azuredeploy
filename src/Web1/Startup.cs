using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web1.Startup))]
namespace Web1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
