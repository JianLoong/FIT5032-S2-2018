using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
   
    public class ToDoHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
        public static void AdminSend(string message)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ToDoHub>();
            hubContext.Clients.All.addNewMessageToPage("admin",message);
        }

    }
}