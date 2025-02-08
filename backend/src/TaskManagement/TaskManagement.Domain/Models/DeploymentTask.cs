namespace TaskManagement.Domain.Models
{
    public class DeploymentTask : BaseEntity
    {
        public TaskType TaskType { get; set; } = new();

        public string Scope { get; set; } = string.Empty;
    }
}
