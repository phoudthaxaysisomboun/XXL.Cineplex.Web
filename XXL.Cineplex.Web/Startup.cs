using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XXL.Cineplex.Web.Startup))]
namespace XXL.Cineplex.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
