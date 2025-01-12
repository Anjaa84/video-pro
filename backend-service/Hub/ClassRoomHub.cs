using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace BackendService.Hubs
{
    public class ClassroomHub : Hub
    {
        // Method for teacher to start the class
        public async Task StartClass(string classId)
        {
            await Clients.Group(classId).SendAsync("ClassStarted", "The class has started.");
        }

        // Method for students to join the class
        public async Task JoinClass(string classId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, classId);
            await Clients.Group(classId).SendAsync("StudentJoined", $"{Context.ConnectionId} has joined.");
        }

        // Method for real-time chat
        public async Task SendMessage(string classId, string message)
        {
            await Clients.Group(classId).SendAsync("ReceiveMessage", Context.ConnectionId, message);
        }
    }
}
