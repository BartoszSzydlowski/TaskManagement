using TaskManagement.Domain.Enums;

namespace TaskManagement.Domain.Models
{
    public abstract class Task : BaseEntity
    {
        public string Content { get; set; } = string.Empty;

        public int Difficulty { get; set; }

        public TaskType TaskType { get; set; } = new();

        public User? User { get; set; } = new();

        public Status Status { get; set; }
    }
}
