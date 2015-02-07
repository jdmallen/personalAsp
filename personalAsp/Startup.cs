using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(personalAsp.Startup))]
namespace personalAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
