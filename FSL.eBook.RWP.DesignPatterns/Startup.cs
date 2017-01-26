using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FSL.eBook.RWP.DesignPatterns.Startup))]
namespace FSL.eBook.RWP.DesignPatterns
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
