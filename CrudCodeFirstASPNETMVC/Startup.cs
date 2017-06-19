using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudCodeFirstASPNETMVC.Startup))]
namespace CrudCodeFirstASPNETMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
