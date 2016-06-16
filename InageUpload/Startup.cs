using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InageUpload.Startup))]
namespace InageUpload
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
