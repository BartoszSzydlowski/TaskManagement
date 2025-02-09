using TaskManagement.Domain.Enums;
using TaskManagement.Domain.Models;

namespace TaskManagement.Infrastructure
{
    public class MockedData
    {
        public List<UserType> UserTypes { get; set; }

        public List<User> Users { get; set; }

        public List<MaintenanceTask> MaintenanceTasks { get; set; }

        public List<DeploymentTask> DeploymentTasks { get; set; }

        public List<ImplementationTask> ImplementationTasks { get; set; }

        public List<TaskType> TaskTypes { get; set; }

        public List<Domain.Models.Task> Tasks { get; set; }

        public MockedData()
        {
            UserTypes =
            [
                new() { Id = 1, Name = "Programmmer" },
                new() { Id = 2, Name = "DevOps/Administrator" }
            ];

            Users =
            [
                new() { Id = 1, Name = "Jan", Surname = "Kowalski", UserType = UserTypes[0] }
            ];

            TaskTypes =
            [
                new() { Id = 1, Name = "Deployment" },
                new() { Id = 2, Name = "Maintenance" },
                new() { Id = 3, Name = "Implementation" },
            ];

            DeploymentTasks =
            [
                new DeploymentTask { Id = 1, Content = "Deploying API on Azure", Difficulty = 1, Scope = "Deploy API to Microsoft Azure with URL mydomain.com", Status = Status.ToDo, TaskType = TaskTypes[0], User = Users[0] },
            ];

            MaintenanceTasks =
            [
                new MaintenanceTask { Id = 2, Content = "Check services on server", Difficulty = 5, DueDate = DateTime.Now, ServerList = "Two domains", ServiceList = "Example server list", Status = Status.ToDo, TaskType = TaskTypes[1] },
            ];

            ImplementationTasks =
            [
                new ImplementationTask { Id = 3, Content = "Create method to return all clients data", Difficulty = 2, TaskContent = "Implement using DDD a method", Status = Status.Done, TaskType = TaskTypes[2], User = Users[0] },
            ];

            Tasks = [.. DeploymentTasks, .. MaintenanceTasks, .. ImplementationTasks];
        }
    }
}
