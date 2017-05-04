using Microsoft.AspNet.SignalR;
using System;

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