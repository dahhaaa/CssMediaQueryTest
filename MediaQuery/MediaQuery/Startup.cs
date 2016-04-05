using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaQuery.Startup))]
namespace MediaQuery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
