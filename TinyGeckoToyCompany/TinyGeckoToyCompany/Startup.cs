using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TinyGeckoToyCompany.Startup))]
namespace TinyGeckoToyCompany
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
