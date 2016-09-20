using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BBT.Startup))]
namespace BBT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
