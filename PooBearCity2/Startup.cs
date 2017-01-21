using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PooBearCity2.Startup))]
namespace PooBearCity2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
