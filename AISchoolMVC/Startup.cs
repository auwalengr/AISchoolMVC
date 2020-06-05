using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AISchoolMVC.Startup))]
namespace AISchoolMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
