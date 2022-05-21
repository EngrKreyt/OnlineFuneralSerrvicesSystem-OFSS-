using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineFuneralSerrvicesSystem_OFSS_.Startup))]
namespace OnlineFuneralSerrvicesSystem_OFSS_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
