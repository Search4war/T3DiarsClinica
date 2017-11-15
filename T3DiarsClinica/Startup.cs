using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(T3DiarsClinica.Startup))]
namespace T3DiarsClinica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
