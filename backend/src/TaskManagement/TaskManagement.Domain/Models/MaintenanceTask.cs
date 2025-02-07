namespace TaskManagement.Domain.Models
{
    public class MaintenanceTask : BaseEntity
    {
        public TaskType TaskType { get; set; } = new();

        public string ServiceList {  get; set; } = string.Empty;

        public string ServerList { get; set; } = string.Empty;
    }
}
