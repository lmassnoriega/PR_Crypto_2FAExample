using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Criptografía.Startup))]
namespace Criptografía
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
