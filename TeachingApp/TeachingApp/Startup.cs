using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeachingApp.Startup))]
namespace TeachingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
