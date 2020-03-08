using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(yazokulum.com.Startup))]
namespace yazokulum.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
