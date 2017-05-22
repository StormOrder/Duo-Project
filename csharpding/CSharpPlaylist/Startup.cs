using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharpPlaylist.Startup))]
namespace CSharpPlaylist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
