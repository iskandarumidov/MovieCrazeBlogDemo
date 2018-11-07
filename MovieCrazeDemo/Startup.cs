using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieCrazeDemo.Startup))]
namespace MovieCrazeDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
