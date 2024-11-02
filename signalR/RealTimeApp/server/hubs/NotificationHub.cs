using Microsoft.AspNetCore.SignalR;

namespace server.hubs
{
    public class NotificationHub : Hub
    {
        private readonly string NotificationTarget = "ReceiveMessage";
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync(NotificationTarget, message);
        }
    }
}