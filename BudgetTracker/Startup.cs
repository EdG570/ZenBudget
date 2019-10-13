using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BudgetTracker.Startup))]
namespace BudgetTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
