using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PTBC_CRUD_Test.Startup))]
namespace PTBC_CRUD_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
