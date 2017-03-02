using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Example_Web.Startup))]
namespace Example_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
