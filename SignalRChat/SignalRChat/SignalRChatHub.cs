using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRChat
{
    public class SignalRChatHub : Hub
    {
        public void BroadCastMessage(String msgFrom, String msg)
        {
            Clients.All.receiveMessage(msgFrom, msg);
        }
    }
}