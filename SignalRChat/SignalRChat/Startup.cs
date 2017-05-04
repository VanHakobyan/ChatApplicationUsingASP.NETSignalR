using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRChat.Startup))]
namespace SignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Add the SignalR Middlewware to the OWIN pipeline
            app.MapSignalR();
        }
    }
}


