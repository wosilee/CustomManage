using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomManager.Startup))]
namespace CustomManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
