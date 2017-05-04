using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ChatApp.Startup))]

namespace ChatApp
{
    public partial class Startup
    {
        public void Config(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}