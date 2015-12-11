using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToptalExpensesTrackerAPI.Startup))]
namespace ToptalExpensesTrackerAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }

}