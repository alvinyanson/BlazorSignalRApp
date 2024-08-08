using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalRApp.Hubs;

public class ChatHub : Hub<IChatClient>
{
    public async Task SendMessage(string user, string message)
    {
        Console.WriteLine($"Connection Id: {Context.ConnectionId}");

        await Clients.Caller.ResponseToCaller("Server message: This message is intended for the caller.");

        await Clients.Others.ResponseToAllExceptCaller("\"Server message: This message is intended for all except the caller.\"");

        await Clients.All.ReceiveMessage(user, message);
    }
}