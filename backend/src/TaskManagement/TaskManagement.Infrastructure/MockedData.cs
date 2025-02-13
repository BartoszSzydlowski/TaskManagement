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
                new() { Id = 1,  Name = "Jan",       Surname = "Kowalski",     UserType = UserTypes[0] },
                new() { Id = 2,  Name = "Anna",      Surname = "Nowak",        UserType = UserTypes[1] },
                new() { Id = 3,  Name = "Marek",     Surname = "Zieliński",    UserType = UserTypes[1] },
                new() { Id = 4,  Name = "Ewa",       Surname = "Wiśniewska",   UserType = UserTypes[0] },
                new() { Id = 5,  Name = "Tomasz",    Surname = "Lewandowski",  UserType = UserTypes[1] },
                new() { Id = 6,  Name = "Piotr",     Surname = "Wozniak",      UserType = UserTypes[0] },
                new() { Id = 7,  Name = "Katarzyna", Surname = "Szymczak",     UserType = UserTypes[1] },
                new() { Id = 8,  Name = "Adam",      Surname = "Nowicki",      UserType = UserTypes[0] },
                new() { Id = 9,  Name = "Monika",    Surname = "Zielinska",    UserType = UserTypes[1] },
                new() { Id = 10, Name = "Lukasz",    Surname = "Malinowski",   UserType = UserTypes[0] }
            ];

            TaskTypes =
            [
                new() { Id = 1, Name = "Deployment" },
                new() { Id = 2, Name = "Maintenance" },
                new() { Id = 3, Name = "Implementation" },
            ];

            DeploymentTasks =
            [
                new() { Id = 1,  Name = "Deploy Task 1 for Anna",   Difficulty = 1, TaskType = TaskTypes[0], Scope = "Deploy service A", Status = Status.ToDo,  User = Users[1] },
                new() { Id = 2,  Name = "Deploy Task 2 for Anna",   Difficulty = 2, TaskType = TaskTypes[0], Scope = "Deploy service B", Status = Status.ToDo,  User = Users[1] },
                new() { Id = 7,  Name = "Deploy Task 3 for Anna",   Difficulty = 1, TaskType = TaskTypes[0], Scope = "Deploy service C", Status = Status.Done,  User = Users[1] },
                new() { Id = 10, Name = "Deploy Task 4 for Anna",   Difficulty = 3, TaskType = TaskTypes[0], Scope = "Deploy service D", Status = Status.ToDo,  User = Users[1] },
                new() { Id = 16, Name = "Deploy Task 5 for Anna",   Difficulty = 3, TaskType = TaskTypes[0], Scope = "Deploy service E", Status = Status.Done,  User = Users[1] },

                new() { Id = 17, Name = "Deploy Task 1 for Marek",  Difficulty = 5, TaskType = TaskTypes[0], Scope = "Deploy module X",  Status = Status.ToDo,  User = Users[2] },
                new() { Id = 23, Name = "Deploy Task 2 for Marek",  Difficulty = 1, TaskType = TaskTypes[0], Scope = "Deploy module Y",  Status = Status.Done,  User = Users[2] },
                new() { Id = 24, Name = "Deploy Task 3 for Marek",  Difficulty = 2, TaskType = TaskTypes[0], Scope = "Deploy module Z",  Status = Status.ToDo,  User = Users[2] },
                new() { Id = 30, Name = "Deploy Task 4 for Marek",  Difficulty = 3, TaskType = TaskTypes[0], Scope = "Deploy module W",  Status = Status.ToDo,  User = Users[2] },
                new() { Id = 31, Name = "Deploy Task 5 for Marek",  Difficulty = 3, TaskType = TaskTypes[0], Scope = "Deploy module V",  Status = Status.Done,  User = Users[2] },

                new() { Id = 37, Name = "Deploy Task 1 for Tomasz", Difficulty = 5, TaskType = TaskTypes[0], Scope = "Deploy app A",     Status = Status.ToDo,  User = Users[4] },
                new() { Id = 38, Name = "Deploy Task 2 for Tomasz", Difficulty = 4, TaskType = TaskTypes[0], Scope = "Deploy app B",     Status = Status.Done,  User = Users[4] },
                new() { Id = 44, Name = "Deploy Task 3 for Tomasz", Difficulty = 1, TaskType = TaskTypes[0], Scope = "Deploy app C",     Status = Status.ToDo,  User = Users[4] },
                new() { Id = 45, Name = "Deploy Task 4 for Tomasz", Difficulty = 3, TaskType = TaskTypes[0], Scope = "Deploy app D",     Status = Status.Done,  User = Users[4] },
                new() { Id = 51, Name = "Deploy Task 5 for Tomasz", Difficulty = 3, TaskType = TaskTypes[0], Scope = "Deploy app E",     Status = Status.ToDo,  User = Users[4] },

                new() { Id = 52, Name = "Deploy Task 1 for Katarzyna", Difficulty = 5, TaskType = TaskTypes[0], Scope = "Deploy infra A", Status = Status.ToDo,  User = Users[6] },
                new() { Id = 58, Name = "Deploy Task 2 for Katarzyna", Difficulty = 1, TaskType = TaskTypes[0], Scope = "Deploy infra B", Status = Status.Done,  User = Users[6] },
                new() { Id = 59, Name = "Deploy Task 3 for Katarzyna", Difficulty = 2, TaskType = TaskTypes[0], Scope = "Deploy infra C", Status = Status.ToDo,  User = Users[6] },
                new() { Id = 65, Name = "Deploy Task 4 for Katarzyna", Difficulty = 3, TaskType = TaskTypes[0], Scope = "Deploy infra D", Status = Status.ToDo,  User = Users[6] },
                new() { Id = 66, Name = "Deploy Task 5 for Katarzyna", Difficulty = 3, TaskType = TaskTypes[0], Scope = "Deploy infra E", Status = Status.Done,  User = Users[6] },

                new() { Id = 71, Name = "Deploy Task 1 for Monika",  Difficulty = 1, TaskType = TaskTypes[0], Scope = "Deploy service F", Status = Status.ToDo,  User = Users[8] },
                new() { Id = 72, Name = "Deploy Task 2 for Monika",  Difficulty = 2, TaskType = TaskTypes[0], Scope = "Deploy service G", Status = Status.Done,  User = Users[8] },
                new() { Id = 73, Name = "Deploy Task 3 for Monika",  Difficulty = 1, TaskType = TaskTypes[0], Scope = "Deploy service H", Status = Status.ToDo,  User = Users[8] },
                new() { Id = 74, Name = "Deploy Task 4 for Monika",  Difficulty = 3, TaskType = TaskTypes[0], Scope = "Deploy service I", Status = Status.ToDo,  User = Users[8] },
                new() { Id = 75, Name = "Deploy Task 5 for Monika",  Difficulty = 3, TaskType = TaskTypes[0], Scope = "Deploy service J", Status = Status.Done,  User = Users[8] },

                new() { Id = 80, Name = "Deploy Task Unassigned 1", Difficulty = 4, TaskType = TaskTypes[0], Scope = "Deploy extra A",  Status = Status.ToDo,  User = null },
                new() { Id = 81, Name = "Deploy Task Unassigned 2", Difficulty = 3, TaskType = TaskTypes[0], Scope = "Deploy extra B",  Status = Status.ToDo,  User = null }
            ];

            MaintenanceTasks =
            [
                new() { Id = 76, Name = "Maint Task 1 for Anna",  Difficulty = 5, DueDate = DateTime.Now, ServerList = "Server A", ServiceList = "DB, API",   Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[1] },
                new() { Id = 77, Name = "Maint Task 2 for Anna",  Difficulty = 1, DueDate = DateTime.Now, ServerList = "Server B", ServiceList = "Web",      Status = Status.Done,  TaskType = TaskTypes[1], User = Users[1] },
                new() { Id = 78, Name = "Maint Task 3 for Anna",  Difficulty = 2, DueDate = DateTime.Now, ServerList = "Server C", ServiceList = "DB",       Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[1] },
                new() { Id = 79, Name = "Maint Task 4 for Anna",  Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server D", ServiceList = "Cache",    Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[1] },
                new() { Id = 80, Name = "Maint Task 5 for Anna",  Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server E", ServiceList = "Logs",     Status = Status.Done,  TaskType = TaskTypes[1], User = Users[1] },

                new() { Id = 82, Name = "Maint Task 1 for Marek", Difficulty = 5, DueDate = DateTime.Now, ServerList = "Server F", ServiceList = "Monitoring", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[2] },
                new() { Id = 83, Name = "Maint Task 2 for Marek", Difficulty = 1, DueDate = DateTime.Now, ServerList = "Server G", ServiceList = "Backup",     Status = Status.Done,  TaskType = TaskTypes[1], User = Users[2] },
                new() { Id = 84, Name = "Maint Task 3 for Marek", Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server H", ServiceList = "Updates",    Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[2] },
                new() { Id = 85, Name = "Maint Task 4 for Marek", Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server I", ServiceList = "Maintenance",Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[2] },
                new() { Id = 86, Name = "Maint Task 5 for Marek", Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server J", ServiceList = "Security",   Status = Status.Done,  TaskType = TaskTypes[1], User = Users[2] },

                new() { Id = 87, Name = "Maint Task 1 for Tomasz", Difficulty = 5, DueDate = DateTime.Now, ServerList = "Server K", ServiceList = "Cluster",    Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[4] },
                new() { Id = 88, Name = "Maint Task 2 for Tomasz", Difficulty = 1, DueDate = DateTime.Now, ServerList = "Server L", ServiceList = "API",        Status = Status.Done,  TaskType = TaskTypes[1], User = Users[4] },
                new() { Id = 89, Name = "Maint Task 3 for Tomasz", Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server M", ServiceList = "DB",         Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[4] },
                new() { Id = 90, Name = "Maint Task 4 for Tomasz", Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server N", ServiceList = "Cache",      Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[4] },
                new() { Id = 91, Name = "Maint Task 5 for Tomasz", Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server O", ServiceList = "Logs",       Status = Status.Done,  TaskType = TaskTypes[1], User = Users[4] },

                new() { Id = 92, Name = "Maint Task 1 for Katarzyna", Difficulty = 5, DueDate = DateTime.Now, ServerList = "Server P", ServiceList = "Monitoring", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[6] },
                new() { Id = 93, Name = "Maint Task 2 for Katarzyna", Difficulty = 1, DueDate = DateTime.Now, ServerList = "Server Q", ServiceList = "Backup",     Status = Status.Done,  TaskType = TaskTypes[1], User = Users[6] },
                new() { Id = 94, Name = "Maint Task 3 for Katarzyna", Difficulty = 2, DueDate = DateTime.Now, ServerList = "Server R", ServiceList = "Updates",    Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[6] },
                new() { Id = 95, Name = "Maint Task 4 for Katarzyna", Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server S", ServiceList = "Maintenance",Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[6] },
                new() { Id = 96, Name = "Maint Task 5 for Katarzyna", Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server T", ServiceList = "Security",   Status = Status.Done,  TaskType = TaskTypes[1], User = Users[6] },

                new() { Id = 97, Name = "Maint Task 1 for Monika", Difficulty = 5, DueDate = DateTime.Now, ServerList = "Server U", ServiceList = "Cluster",    Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[8] },
                new() { Id = 98, Name = "Maint Task 2 for Monika", Difficulty = 1, DueDate = DateTime.Now, ServerList = "Server V", ServiceList = "API",        Status = Status.Done,  TaskType = TaskTypes[1], User = Users[8] },
                new() { Id = 99, Name = "Maint Task 3 for Monika", Difficulty = 2, DueDate = DateTime.Now, ServerList = "Server W", ServiceList = "DB",         Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[8] },
                new() { Id = 100,Name = "Maint Task 4 for Monika", Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server X", ServiceList = "Cache",      Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users[8] },
                new() { Id = 101,Name = "Maint Task 5 for Monika", Difficulty = 3, DueDate = DateTime.Now, ServerList = "Server Y", ServiceList = "Logs",       Status = Status.Done,  TaskType = TaskTypes[1], User = Users[8] },

                new() { Id = 102, Name = "Maint Task Unassigned 1", Difficulty = 4, DueDate = DateTime.Now, ServerList = "Server Z",  ServiceList = "Extra", Status = Status.ToDo,  TaskType = TaskTypes[1], User = null },
                new() { Id = 103, Name = "Maint Task Unassigned 2", Difficulty = 2, DueDate = DateTime.Now, ServerList = "Server AA", ServiceList = "Extra", Status = Status.ToDo,  TaskType = TaskTypes[1], User = null }
            ];

            ImplementationTasks =
            [
                new() { Id = 3,  Name = "Impl Task 1 for Jan",  Difficulty = 4, TaskContent = "Improve login flow",           Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[0] },
                new() { Id = 8,  Name = "Impl Task 2 for Jan",  Difficulty = 5, TaskContent = "Refactor payment module",       Status = Status.Done,  TaskType = TaskTypes[2], User = Users[0] },
                new() { Id = 15, Name = "Impl Task 3 for Jan",  Difficulty = 1, TaskContent = "Fix minor UI bug",              Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[0] },
                new() { Id = 22, Name = "Impl Task 4 for Jan",  Difficulty = 2, TaskContent = "Update documentation",          Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[0] },
                new() { Id = 29, Name = "Impl Task 5 for Jan",  Difficulty = 1, TaskContent = "Code cleanup",                  Status = Status.Done,  TaskType = TaskTypes[2], User = Users[0] },

                new() { Id = 36, Name = "Impl Task 1 for Ewa",  Difficulty = 4, TaskContent = "Revamp auth module",            Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[3] },
                new() { Id = 43, Name = "Impl Task 2 for Ewa",  Difficulty = 5, TaskContent = "Implement caching",             Status = Status.Done,  TaskType = TaskTypes[2], User = Users[3] },
                new() { Id = 50, Name = "Impl Task 3 for Ewa",  Difficulty = 2, TaskContent = "Fix UI alignment",              Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[3] },
                new() { Id = 57, Name = "Impl Task 4 for Ewa",  Difficulty = 1, TaskContent = "Update CSS",                    Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[3] },
                new() { Id = 64, Name = "Impl Task 5 for Ewa",  Difficulty = 2, TaskContent = "Minor bug fix",                 Status = Status.Done,  TaskType = TaskTypes[2], User = Users[3] },

                new() { Id = 6,  Name = "Impl Task 1 for Piotr",  Difficulty = 4, TaskContent = "Improve module X",         Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[5] },
                new() { Id = 11, Name = "Impl Task 2 for Piotr",  Difficulty = 5, TaskContent = "Redesign API",             Status = Status.Done,  TaskType = TaskTypes[2], User = Users[5] },
                new() { Id = 18, Name = "Impl Task 3 for Piotr",  Difficulty = 1, TaskContent = "Fix typo",                 Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[5] },
                new() { Id = 25, Name = "Impl Task 4 for Piotr",  Difficulty = 2, TaskContent = "Refactor helper method",   Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[5] },
                new() { Id = 32, Name = "Impl Task 5 for Piotr",  Difficulty = 1, TaskContent = "Code cleanup",             Status = Status.Done,  TaskType = TaskTypes[2], User = Users[5] },

                new() { Id = 39, Name = "Impl Task 1 for Adam",  Difficulty = 4, TaskContent = "Implement feature A",      Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[7] },
                new() { Id = 46, Name = "Impl Task 2 for Adam",  Difficulty = 5, TaskContent = "Upgrade module B",         Status = Status.Done,  TaskType = TaskTypes[2], User = Users[7] },
                new() { Id = 53, Name = "Impl Task 3 for Adam",  Difficulty = 1, TaskContent = "Fix minor bug",            Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[7] },
                new() { Id = 60, Name = "Impl Task 4 for Adam",  Difficulty = 2, TaskContent = "Improve UI",               Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[7] },
                new() { Id = 67, Name = "Impl Task 5 for Adam",  Difficulty = 1, TaskContent = "Code refactoring",         Status = Status.Done,  TaskType = TaskTypes[2], User = Users[7] },

                new() { Id = 9,  Name = "Impl Task 1 for Lukasz",  Difficulty = 4, TaskContent = "Develop new API",       Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[9] },
                new() { Id = 14, Name = "Impl Task 2 for Lukasz",  Difficulty = 5, TaskContent = "Refactor legacy code",   Status = Status.Done,  TaskType = TaskTypes[2], User = Users[9] },
                new() { Id = 21, Name = "Impl Task 3 for Lukasz",  Difficulty = 1, TaskContent = "Fix minor issue",         Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[9] },
                new() { Id = 28, Name = "Impl Task 4 for Lukasz",  Difficulty = 2, TaskContent = "Update docs",             Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users[9] },
                new() { Id = 35, Name = "Impl Task 5 for Lukasz",  Difficulty = 1, TaskContent = "Code cleanup",            Status = Status.Done,  TaskType = TaskTypes[2], User = Users[9] },

                new() { Id = 72, Name = "Impl Task Unassigned 1", Difficulty = 4, TaskContent = "Optimize service",        Status = Status.ToDo,  TaskType = TaskTypes[2], User = null },
                new() { Id = 73, Name = "Impl Task Unassigned 2", Difficulty = 3, TaskContent = "Improve test coverage",   Status = Status.ToDo,  TaskType = TaskTypes[2], User = null },
                new() { Id = 74, Name = "Impl Task Unassigned 3", Difficulty = 5, TaskContent = "Redesign module",         Status = Status.ToDo,  TaskType = TaskTypes[2], User = null },
                new() { Id = 75, Name = "Impl Task Unassigned 4", Difficulty = 2, TaskContent = "Minor refactoring",       Status = Status.ToDo,  TaskType = TaskTypes[2], User = null },
                new() { Id = 76, Name = "Impl Task Unassigned 5", Difficulty = 1, TaskContent = "Fix logging issues",      Status = Status.ToDo,  TaskType = TaskTypes[2], User = null }
            ];

            Tasks = [.. DeploymentTasks, .. MaintenanceTasks, .. ImplementationTasks];
        }
    }
}
