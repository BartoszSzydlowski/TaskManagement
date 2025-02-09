using TaskManagement.Domain.Models;

namespace TaskManagement.Infrastructure
{
    public class MockedData
    {
        public List<Domain.Models.Task> Tasks { get; set; } = [];

        public List<TaskType> TaskTypes { get; set; } =
        [
            new() { Id = 1, Name = "Deployment" },
            new() { Id = 2, Name = "Maintenance" },
            new() { Id = 3, Name = "Implementation" },
        ];

        public List<User> Users { get; set; } = [];

        public List<UserType> UserTypes { get; set; } = [];

        public List<MaintenanceTask> MaintenanceTasks { get; set; } = [];

        public List<DeploymentTask> DeploymentTasks { get; set; } = [];

        public List<ImplementationTask> ImplementationTasks { get; set; } = [];
    }
}