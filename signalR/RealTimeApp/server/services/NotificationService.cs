using Microsoft.AspNetCore.SignalR;
using server.hubs;

namespace server.services
{
    public class NotificationService
    {
        private readonly IHubContext<NotificationHub> _hubContext;
        private readonly string NotificationTarget = "ReceiveMessage";

        public NotificationService(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task SendMessage(string message)
        {
            await _hubContext.Clients.All.SendAsync(NotificationTarget, message);
        }
    }
}