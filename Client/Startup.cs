using Autofac;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Client.Startup))]
namespace Client
{
    public partial class Startup
    {
        public static IContainer Container { get; set; }

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app, Container);
        }
    }
}
