namespace TaskManagement.Domain.Models
{
    public class Task : BaseEntity
    {
        public string Text { get; set; } = string.Empty;

        public int Difficulty { get; set; }

        public TaskType TaskType { get; set; } = new();

        public User User { get; set; } = new();
    }
}
