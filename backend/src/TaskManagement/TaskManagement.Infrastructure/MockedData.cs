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
                new() { Id = 1, Name = "Jan", Surname = "Kowalski", UserType = UserTypes[0] },
                new() { Id = 2, Name = "Anna", Surname = "Nowak", UserType = UserTypes[1] },
                new() { Id = 3, Name = "Marek", Surname = "Zieliński", UserType = UserTypes[1] },
                new() { Id = 4, Name = "Ewa", Surname = "Wiśniewska", UserType = UserTypes[0] },
                new() { Id = 5, Name = "Tomasz", Surname = "Lewandowski", UserType = UserTypes[1] }
            ];

            TaskTypes =
            [
                new() { Id = 1, Name = "Deployment" },
                new() { Id = 2, Name = "Maintenance" },
                new() { Id = 3, Name = "Implementation" },
            ];

            DeploymentTasks =
            [
                new() { Id = 1, Name = "Deploy API on Azure", Difficulty = 1, Scope = "Deploy API to Azure", Status = Status.ToDo, TaskType = TaskTypes[0], User = Users[2] },
                new() { Id = 2, Name = "Deploy Database on AWS", Difficulty = 3, Scope = "Deploy database to AWS", Status = Status.Done, TaskType = TaskTypes[0], User = Users[1] },
                new() { Id = 3, Name = "Migrate microservices to Kubernetes", Difficulty = 5, Scope = "Migrate services to Kubernetes", Status = Status.ToDo, TaskType = TaskTypes[0] },
                new() { Id = 4, Name = "Set up CI/CD pipeline", Difficulty = 2, Scope = "Create CI/CD for microservices", Status = Status.ToDo, TaskType = TaskTypes[0], User = Users[4] },
                new() { Id = 5, Name = "Configure load balancing", Difficulty = 4, Scope = "Set up load balancer", Status = Status.ToDo, TaskType = TaskTypes[0] }
            ];

            MaintenanceTasks =
            [
                new() { Id = 6, Name = "Check server logs", Difficulty = 3, DueDate = DateTime.Now, ServerList = "Production Servers", ServiceList = "API, DB", Status = Status.ToDo, TaskType = TaskTypes[1], User = Users[3] },
                new() { Id = 7, Name = "Upgrade system packages", Difficulty = 4, DueDate = DateTime.Now, ServerList = "All servers", ServiceList = "OS and dependencies", Status = Status.ToDo, TaskType = TaskTypes[1] },
                new() { Id = 8, Name = "Monitor database performance", Difficulty = 5, DueDate = DateTime.Now, ServerList = "Database Cluster", ServiceList = "MySQL, PostgreSQL", Status = Status.Done, TaskType = TaskTypes[1], User = Users[2] },
                new() { Id = 9, Name = "Patch security vulnerabilities", Difficulty = 5, DueDate = DateTime.Now, ServerList = "All environments", ServiceList = "Security audit", Status = Status.ToDo, TaskType = TaskTypes[1] },
                new() { Id = 10, Name = "Backup and restore testing", Difficulty = 2, DueDate = DateTime.Now, ServerList = "Backup Servers", ServiceList = "Daily backups", Status = Status.ToDo, TaskType = TaskTypes[1] }
            ];

            ImplementationTasks =
            [
                new() { Id = 11, Name = "Refactor authentication module", Difficulty = 3, TaskContent = "Improve OAuth2 flow", Status = Status.Done, TaskType = TaskTypes[2], User = Users[0] },
                new() { Id = 12, Name = "Implement caching layer", Difficulty = 4, TaskContent = "Add Redis cache", Status = Status.ToDo, TaskType = TaskTypes[2], User = Users[3] },
                new() { Id = 13, Name = "Optimize database queries", Difficulty = 5, TaskContent = "Improve indexing", Status = Status.ToDo, TaskType = TaskTypes[2] },
                new() { Id = 14, Name = "Develop REST API for reports", Difficulty = 2, TaskContent = "Expose report data", Status = Status.Done, TaskType = TaskTypes[2] },
                new() { Id = 15, Name = "Write unit tests for user service", Difficulty = 1, TaskContent = "Add xUnit tests", Status = Status.ToDo, TaskType = TaskTypes[2], User = Users[0] }
            ];

            Tasks = [.. DeploymentTasks, .. MaintenanceTasks, .. ImplementationTasks];
        }
    }
}
