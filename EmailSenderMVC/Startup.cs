using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmailSenderMVC.Startup))]
namespace EmailSenderMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
