using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MicroWaveFood.Startup))]
namespace MicroWaveFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
