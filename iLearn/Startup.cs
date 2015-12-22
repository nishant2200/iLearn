using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iLearn.Startup))]
namespace iLearn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
