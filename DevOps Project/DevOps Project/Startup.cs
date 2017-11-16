using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOps_Project.Startup))]
namespace DevOps_Project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
