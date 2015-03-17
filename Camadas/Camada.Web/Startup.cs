using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Camada.Web.Startup))]
namespace Camada.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
