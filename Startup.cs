using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week11.Startup))]
namespace Week11
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
