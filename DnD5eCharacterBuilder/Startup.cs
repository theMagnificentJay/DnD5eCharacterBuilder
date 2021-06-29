using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DnD5eCharacterBuilder.Startup))]
namespace DnD5eCharacterBuilder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
