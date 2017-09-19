using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BartenderApp01.Startup))]
namespace BartenderApp01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
