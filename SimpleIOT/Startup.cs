using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleIOT.Startup))]
namespace SimpleIOT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
