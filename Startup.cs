using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpirenceIT_MidTerm1.Startup))]
namespace ExpirenceIT_MidTerm1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
