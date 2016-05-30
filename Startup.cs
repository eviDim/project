using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AegeanProject.Startup))]
namespace AegeanProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }
    }
}
