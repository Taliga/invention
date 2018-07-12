using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculatorWeb.Startup))]
namespace CalculatorWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
