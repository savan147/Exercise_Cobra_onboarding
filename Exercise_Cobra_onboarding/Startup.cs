using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exercise_Cobra_onboarding.Startup))]
namespace Exercise_Cobra_onboarding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
