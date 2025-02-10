using TaskManagement.Domain.Models;

namespace TaskManagement.Application.Requests
{
    public class AddTaskToUserRequest
    {
        public int[] TasksIds { get; set; } = [];

        public int UserId { get; set; }
    }
}
