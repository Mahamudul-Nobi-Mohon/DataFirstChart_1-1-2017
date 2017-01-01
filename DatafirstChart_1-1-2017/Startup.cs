using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatafirstChart_1_1_2017.Startup))]
namespace DatafirstChart_1_1_2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
