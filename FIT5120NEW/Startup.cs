using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5120NEW.Startup))]
namespace FIT5120NEW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
