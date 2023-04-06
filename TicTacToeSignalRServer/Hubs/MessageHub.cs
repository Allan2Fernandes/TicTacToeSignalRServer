using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace TicTacToeSignalRServer.Hubs
{
    public class MessageHub: Hub
    {
        public async Task SendMessage(string message, string userTurn, bool ThereIsWinner)
        {
            await Clients.All.SendAsync("ReceiveMessage", message, userTurn, ThereIsWinner);
        }
    }
}
