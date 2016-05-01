using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arkeometriks.Web.Startup))]
namespace Arkeometriks.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
