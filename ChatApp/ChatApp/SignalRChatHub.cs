using Microsoft.AspNet.SignalR;

namespace ChatApp
{
    public class SignalRChatHub:Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
    }
}