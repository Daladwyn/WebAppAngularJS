using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAngularJS.Startup))]
namespace WebAppAngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
