using Microsoft.AspNet.SignalR;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatApp
{
    public partial class Basic
    {
        public void Config(IAppBuilder app)
        {
            app.MapSignalR();
        }
        public class ChatHub : Hub
        {
            public void send(string name,string message)
            {
                Clients.All.broadcastMessage(name, message);
            }
        }
    }
}