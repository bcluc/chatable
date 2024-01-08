using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace Chatable.DI
{
    public class MessageHubManager
    {
        public HubConnection? HubConnection;
    }
}
