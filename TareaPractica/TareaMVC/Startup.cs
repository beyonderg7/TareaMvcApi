using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TareaMVC.Startup))]
namespace TareaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
