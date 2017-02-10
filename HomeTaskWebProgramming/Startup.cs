using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeTaskWebProgramming.Startup))]
namespace HomeTaskWebProgramming
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
