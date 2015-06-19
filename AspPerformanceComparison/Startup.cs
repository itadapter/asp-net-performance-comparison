using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspPerformanceComparison.Startup))]
namespace AspPerformanceComparison
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
