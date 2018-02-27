using Microsoft.AspNetCore.SignalR;

namespace AzureHost
{
    public class ChatHub : Hub
    {
        public void SendToAll(string name, string message)
        {
            Clients.All.InvokeAsync("sendToAll",name, message);
        }
        public void SendMessage(string message)
        {
            Clients.All.InvokeAsync(message);
        }
    }
}