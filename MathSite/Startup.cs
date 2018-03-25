using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MathSite.Startup))]
namespace MathSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
