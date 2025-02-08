using TaskManagement.Domain.Enums;

namespace TaskManagement.Domain.Models
{
    public abstract class Task : BaseEntity
    {
        public string Content { get; set; } = string.Empty;

        public int Difficulty { get; set; }

        public User? User { get; set; } = new();

        public Status Status { get; set; }
    }
}
