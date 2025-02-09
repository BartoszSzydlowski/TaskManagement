namespace TaskManagement.Domain.Models
{
    public class DeploymentTask : BaseTask
    {
        public string Scope { get; set; } = string.Empty;
    }
}