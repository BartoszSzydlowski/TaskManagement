using TaskManagement.Common;

namespace TaskManagement.Domain.Models
{
    public class ImplementationTask : BaseEntity
    {
        public TaskType TaskType { get; set; } = new();

        public string Content { get; set; } = string.Empty;

        public Status Status { get; set; }
    }
}
