using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LB.ProjetoAgenda.MVC.Startup))]
namespace LB.ProjetoAgenda.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
