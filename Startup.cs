using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SP749415_MIS4200.Startup))]
namespace SP749415_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
