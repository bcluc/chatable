using AgoraRTC.Models;
using Chatable.Data.Components.Dialog.Lam;
using Chatable.Data.Entitles;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.JSInterop;
using MudBlazor;
using System.ComponentModel;

namespace Chatable.DI
{
    public class CallHubManager
    {
        public HubConnection? HubConnection;
        public bool isIdle = true;
    }
}
