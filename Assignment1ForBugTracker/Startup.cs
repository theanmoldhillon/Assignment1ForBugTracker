using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment1ForBugTracker.Startup))]
namespace Assignment1ForBugTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
