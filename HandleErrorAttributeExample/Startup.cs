using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandleErrorAttributeExample.Startup))]
namespace HandleErrorAttributeExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
