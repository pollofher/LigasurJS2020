using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LigaBarrial2020.Startup))]
namespace LigaBarrial2020
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
