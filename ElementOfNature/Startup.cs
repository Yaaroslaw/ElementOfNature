using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElementOfNature.Startup))]
namespace ElementOfNature
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
