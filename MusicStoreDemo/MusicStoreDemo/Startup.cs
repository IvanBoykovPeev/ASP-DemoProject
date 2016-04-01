using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicStoreDemo.Startup))]
namespace MusicStoreDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
