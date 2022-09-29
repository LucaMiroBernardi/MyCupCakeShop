using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CupcakeEntity.Startup))]
namespace CupcakeEntity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
