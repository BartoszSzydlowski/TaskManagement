namespace TaskManagement.Domain.Models
{
    public class DeploymentTask : Task
    {
        public string Scope { get; set; } = string.Empty;
    }
}
