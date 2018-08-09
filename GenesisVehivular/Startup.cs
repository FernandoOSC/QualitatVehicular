using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GenesisVehivular.Startup))]
namespace GenesisVehivular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
