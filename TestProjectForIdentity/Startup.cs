using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestProjectForIdentity.Startup))]
namespace TestProjectForIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
