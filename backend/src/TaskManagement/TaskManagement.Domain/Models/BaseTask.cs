namespace TaskManagement.Domain.Models
{
    public class BaseTask : BaseEntity
    {
        public TaskType TaskType { get; set; } = new();
    }
}
