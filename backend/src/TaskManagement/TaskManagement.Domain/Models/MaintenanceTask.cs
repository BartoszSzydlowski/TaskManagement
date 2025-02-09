namespace TaskManagement.Domain.Models
{
    public class MaintenanceTask : BaseTask
    {
        public DateTime DueDate { get; set; }

        public string ServiceList { get; set; } = string.Empty;

        public string ServerList { get; set; } = string.Empty;
    }
}
