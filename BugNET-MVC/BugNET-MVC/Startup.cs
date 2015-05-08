using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BugNET_MVC.Startup))]
namespace BugNET_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
