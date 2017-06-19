using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudOperationJquery.Startup))]
namespace CrudOperationJquery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
