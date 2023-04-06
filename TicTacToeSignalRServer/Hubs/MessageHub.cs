using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace TicTacToeSignalRServer.Hubs
{
    public class MessageHub: Hub
    {
        public async Task SendMessage(string message)
        {
            Debug.WriteLine("Message received at the server: " + message);
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
