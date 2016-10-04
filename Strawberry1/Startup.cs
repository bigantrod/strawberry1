using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Strawberry1.Startup))]
namespace Strawberry1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
