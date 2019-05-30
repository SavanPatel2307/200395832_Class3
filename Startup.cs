using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200395832_Class3.Startup))]
namespace _200395832_Class3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
