using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiceAdmin.Startup))]
namespace ServiceAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
