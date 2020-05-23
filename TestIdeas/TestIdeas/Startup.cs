using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestIdeas.Startup))]
namespace TestIdeas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
