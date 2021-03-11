using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vertikal_Elagag.Startup))]
namespace Vertikal_Elagag
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
