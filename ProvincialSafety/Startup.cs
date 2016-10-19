using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvincialSafety.Startup))]
namespace ProvincialSafety
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
