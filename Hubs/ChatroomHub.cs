using System;
using Microsoft.AspNetCore.SignalR;

namespace Chatroom.Hubs
{
    public class ChatroomHub : Hub
    {
        public void SendMessage(string message, string user, DateTimeOffset time)
        {
            var messageViewModel = new MessageViewModel { Message = message, User = user, When = time};

            Clients.All.onMessage(messageViewModel);
        }
    }

    public class MessageViewModel
    {
        public string Message { get; set; }
        public string User { get; set; }
        public DateTimeOffset When { get; set; }
    }
}