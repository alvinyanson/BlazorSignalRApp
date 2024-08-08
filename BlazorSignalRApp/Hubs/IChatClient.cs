namespace BlazorSignalRApp.Hubs
{
    public interface IChatClient
    {
        Task ResponseToCaller(string message);
        Task ResponseToAllExceptCaller(string message);
        Task ReceiveMessage(string user, string message);
    }
}
