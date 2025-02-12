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
                new () { Id = 1,  Name = "Alice",   Surname = "Smith",    UserType = UserTypes[0] }, // 7 tasks
                new () { Id = 3,  Name = "Carol",   Surname = "Taylor",   UserType = UserTypes[0] }, // 7 tasks
                new () { Id = 5,  Name = "Eve",     Surname = "Davis",    UserType = UserTypes[0] }, // 6 tasks
                new () { Id = 7,  Name = "Grace",   Surname = "Wilson",   UserType = UserTypes[0] }, // 6 tasks
                new () { Id = 9,  Name = "Ivan",    Surname = "Taylor",   UserType = UserTypes[0] }, // 6 tasks
                new () { Id = 11, Name = "Mallory", Surname = "Thomas",   UserType = UserTypes[0] }, // 6 tasks

                new () { Id = 2,  Name = "Bob",     Surname = "Jones",    UserType = UserTypes[1] }, // 7 tasks
                new () { Id = 4,  Name = "David",   Surname = "Brown",    UserType = UserTypes[1] }, // 6 tasks
                new () { Id = 6,  Name = "Frank",   Surname = "Miller",   UserType = UserTypes[1] }, // 6 tasks
                new () { Id = 8,  Name = "Heidi",   Surname = "Moore",    UserType = UserTypes[1] }, // 6 tasks
                new () { Id = 10, Name = "Judy",    Surname = "Anderson", UserType = UserTypes[1] }, // 6 tasks
                new () { Id = 12, Name = "Oscar",   Surname = "Jackson",  UserType = UserTypes[1] }  // 6 tasks
            ];

            TaskTypes =
            [
                new() { Id = 1, Name = "Deployment" },
                new() { Id = 2, Name = "Maintenance" },
                new() { Id = 3, Name = "Implementation" },
            ];

            DeploymentTasks =
            [
                new () { Id = 4,  Name = "Deploy Task 4",  Difficulty = 2, Scope = "Bob Deploy 1",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 2) },
                new () { Id = 8,  Name = "Deploy Task 8",  Difficulty = 5, Scope = "Bob Deploy 2",  Status = Status.Done,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 2) },
                new () { Id = 12, Name = "Deploy Task 12", Difficulty = 3, Scope = "Bob Deploy 3",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 2) },
                new () { Id = 16, Name = "Deploy Task 16", Difficulty = 2, Scope = "Bob Deploy 4",  Status = Status.Done,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 2) },

                new () { Id = 20, Name = "Deploy Task 20", Difficulty = 2, Scope = "David Deploy 1",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 4) },
                new () { Id = 24, Name = "Deploy Task 24", Difficulty = 5, Scope = "David Deploy 2",  Status = Status.Done,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 4) },
                new () { Id = 28, Name = "Deploy Task 28", Difficulty = 3, Scope = "David Deploy 3",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 4) },

                new () { Id = 32, Name = "Deploy Task 32", Difficulty = 2, Scope = "Frank Deploy 1",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 6) },
                new () { Id = 36, Name = "Deploy Task 36", Difficulty = 5, Scope = "Frank Deploy 2",  Status = Status.Done,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 6) },
                new () { Id = 40, Name = "Deploy Task 40", Difficulty = 3, Scope = "Frank Deploy 3",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 6) },

                new () { Id = 44, Name = "Deploy Task 44", Difficulty = 2, Scope = "Heidi Deploy 1",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 8) },
                new () { Id = 48, Name = "Deploy Task 48", Difficulty = 5, Scope = "Heidi Deploy 2",  Status = Status.Done,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 8) },
                new () { Id = 52, Name = "Deploy Task 52", Difficulty = 3, Scope = "Heidi Deploy 3",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 8) },

                new () { Id = 56, Name = "Deploy Task 56", Difficulty = 2, Scope = "Judy Deploy 1",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 10) },
                new () { Id = 60, Name = "Deploy Task 60", Difficulty = 5, Scope = "Judy Deploy 2",  Status = Status.Done,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 10) },
                new () { Id = 64, Name = "Deploy Task 64", Difficulty = 3, Scope = "Judy Deploy 3",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 10) },

                new () { Id = 68, Name = "Deploy Task 68", Difficulty = 2, Scope = "Oscar Deploy 1",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 12) },
                new () { Id = 72, Name = "Deploy Task 72", Difficulty = 5, Scope = "Oscar Deploy 2",  Status = Status.Done,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 12) },
                new () { Id = 76, Name = "Deploy Task 76", Difficulty = 3, Scope = "Oscar Deploy 3",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = Users.First(u => u.Id == 12) },

                new () { Id = 80,  Name = "Deploy Task 80",  Difficulty = 2, Scope = "Unassigned Deploy 1",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = null },
                new () { Id = 84,  Name = "Deploy Task 84",  Difficulty = 5, Scope = "Unassigned Deploy 2",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = null },
                new () { Id = 88,  Name = "Deploy Task 88",  Difficulty = 3, Scope = "Unassigned Deploy 3",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = null },
                new () { Id = 92,  Name = "Deploy Task 92",  Difficulty = 2, Scope = "Unassigned Deploy 4",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = null },
                new () { Id = 96,  Name = "Deploy Task 96",  Difficulty = 5, Scope = "Unassigned Deploy 5",  Status = Status.ToDo,  TaskType = TaskTypes[0], User = null },
                new () { Id = 100, Name = "Deploy Task 100", Difficulty = 3, Scope = "Unassigned Deploy 6", Status = Status.ToDo,  TaskType = TaskTypes[0], User = null },
                new () { Id = 104, Name = "Deploy Task 104", Difficulty = 2, Scope = "Unassigned Deploy 7", Status = Status.ToDo,  TaskType = TaskTypes[0], User = null },
                new () { Id = 108, Name = "Deploy Task 108", Difficulty = 5, Scope = "Unassigned Deploy 8", Status = Status.ToDo,  TaskType = TaskTypes[0], User = null },
                new () { Id = 112, Name = "Deploy Task 112", Difficulty = 3, Scope = "Unassigned Deploy 9", Status = Status.ToDo,  TaskType = TaskTypes[0], User = null }
            ];

            MaintenanceTasks =
            [
                new () { Id = 2,  Name = "Maint Task 2",  Difficulty = 3, DueDate = DateTime.Now.AddDays(2),  ServerList = "Bob Maint 1",  ServiceList = "Svc A", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 2) },
                new () { Id = 6,  Name = "Maint Task 6",  Difficulty = 2, DueDate = DateTime.Now.AddDays(6),  ServerList = "Bob Maint 2",  ServiceList = "Svc A", Status = Status.Done,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 2) },
                new () { Id = 10, Name = "Maint Task 10", Difficulty = 3, DueDate = DateTime.Now.AddDays(10), ServerList = "Bob Maint 3",  ServiceList = "Svc A", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 2) },

                new () { Id = 14, Name = "Maint Task 14", Difficulty = 3, DueDate = DateTime.Now.AddDays(14), ServerList = "David Maint 1",  ServiceList = "Svc B", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 4) },
                new () { Id = 18, Name = "Maint Task 18", Difficulty = 2, DueDate = DateTime.Now.AddDays(18), ServerList = "David Maint 2",  ServiceList = "Svc B", Status = Status.Done,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 4) },
                new () { Id = 22, Name = "Maint Task 22", Difficulty = 3, DueDate = DateTime.Now.AddDays(22), ServerList = "David Maint 3",  ServiceList = "Svc B", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 4) },

                new () { Id = 26, Name = "Maint Task 26", Difficulty = 3, DueDate = DateTime.Now.AddDays(26), ServerList = "Frank Maint 1",  ServiceList = "Svc C", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 6) },
                new () { Id = 30, Name = "Maint Task 30", Difficulty = 2, DueDate = DateTime.Now.AddDays(30), ServerList = "Frank Maint 2",  ServiceList = "Svc C", Status = Status.Done,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 6) },
                new () { Id = 34, Name = "Maint Task 34", Difficulty = 3, DueDate = DateTime.Now.AddDays(34), ServerList = "Frank Maint 3",  ServiceList = "Svc C", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 6) },

                new () { Id = 38, Name = "Maint Task 38", Difficulty = 3, DueDate = DateTime.Now.AddDays(38), ServerList = "Heidi Maint 1",  ServiceList = "Svc D", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 8) },
                new () { Id = 42, Name = "Maint Task 42", Difficulty = 2, DueDate = DateTime.Now.AddDays(42), ServerList = "Heidi Maint 2",  ServiceList = "Svc D", Status = Status.Done,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 8) },
                new () { Id = 46, Name = "Maint Task 46", Difficulty = 3, DueDate = DateTime.Now.AddDays(46), ServerList = "Heidi Maint 3",  ServiceList = "Svc D", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 8) },

                new () { Id = 50, Name = "Maint Task 50", Difficulty = 3, DueDate = DateTime.Now.AddDays(50), ServerList = "Judy Maint 1",  ServiceList = "Svc E", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 10) },
                new () { Id = 54, Name = "Maint Task 54", Difficulty = 2, DueDate = DateTime.Now.AddDays(54), ServerList = "Judy Maint 2",  ServiceList = "Svc E", Status = Status.Done,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 10) },
                new () { Id = 58, Name = "Maint Task 58", Difficulty = 3, DueDate = DateTime.Now.AddDays(58), ServerList = "Judy Maint 3",  ServiceList = "Svc E", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 10) },

                new () { Id = 62, Name = "Maint Task 62", Difficulty = 3, DueDate = DateTime.Now.AddDays(62), ServerList = "Oscar Maint 1",  ServiceList = "Svc F", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 12) },
                new () { Id = 66, Name = "Maint Task 66", Difficulty = 2, DueDate = DateTime.Now.AddDays(66), ServerList = "Oscar Maint 2",  ServiceList = "Svc F", Status = Status.Done,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 12) },
                new () { Id = 70, Name = "Maint Task 70", Difficulty = 3, DueDate = DateTime.Now.AddDays(70), ServerList = "Oscar Maint 3",  ServiceList = "Svc F", Status = Status.ToDo,  TaskType = TaskTypes[1], User = Users.First(u => u.Id == 12) },

                new () { Id = 74, Name = "Maint Task 74", Difficulty = 3, DueDate = DateTime.Now.AddDays(74), ServerList = "Unassigned Maint 1", ServiceList = "Svc X", Status = Status.ToDo,  TaskType = TaskTypes[1], User = null },
                new () { Id = 78, Name = "Maint Task 78", Difficulty = 2, DueDate = DateTime.Now.AddDays(78), ServerList = "Unassigned Maint 2", ServiceList = "Svc X", Status = Status.ToDo,  TaskType = TaskTypes[1], User = null },
                new () { Id = 82, Name = "Maint Task 82", Difficulty = 3, DueDate = DateTime.Now.AddDays(82), ServerList = "Unassigned Maint 3", ServiceList = "Svc X", Status = Status.ToDo,  TaskType = TaskTypes[1], User = null },
                new () { Id = 86, Name = "Maint Task 86", Difficulty = 3, DueDate = DateTime.Now.AddDays(86), ServerList = "Unassigned Maint 4", ServiceList = "Svc X", Status = Status.ToDo,  TaskType = TaskTypes[1], User = null },
                new () { Id = 90, Name = "Maint Task 90", Difficulty = 2, DueDate = DateTime.Now.AddDays(90), ServerList = "Unassigned Maint 5", ServiceList = "Svc X", Status = Status.ToDo,  TaskType = TaskTypes[1], User = null },
                new () { Id = 94, Name = "Maint Task 94", Difficulty = 3, DueDate = DateTime.Now.AddDays(94), ServerList = "Unassigned Maint 6", ServiceList = "Svc X", Status = Status.ToDo,  TaskType = TaskTypes[1], User = null },
                new () { Id = 98, Name = "Maint Task 98", Difficulty = 3, DueDate = DateTime.Now.AddDays(98), ServerList = "Unassigned Maint 7", ServiceList = "Svc X", Status = Status.ToDo,  TaskType = TaskTypes[1], User = null },
                new () { Id = 102, Name = "Maint Task 102", Difficulty = 2, DueDate = DateTime.Now.AddDays(102), ServerList = "Unassigned Maint 8", ServiceList = "Svc X", Status = Status.ToDo,  TaskType = TaskTypes[1], User = null }
            ];

            ImplementationTasks =
            [
                new () { Id = 1,  Name = "Impl Task 1",  Difficulty = 2, TaskContent = "Alice Task 1",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 1) },
                new () { Id = 3,  Name = "Impl Task 3",  Difficulty = 5, TaskContent = "Alice Task 2",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 1) },
                new () { Id = 5,  Name = "Impl Task 5",  Difficulty = 3, TaskContent = "Alice Task 3",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 1) },
                new () { Id = 7,  Name = "Impl Task 7",  Difficulty = 3, TaskContent = "Alice Task 4",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 1) },
                new () { Id = 9,  Name = "Impl Task 9",  Difficulty = 2, TaskContent = "Alice Task 5",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 1) },
                new () { Id = 11, Name = "Impl Task 11", Difficulty = 5, TaskContent = "Alice Task 6",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 1) },
                new () { Id = 13, Name = "Impl Task 13", Difficulty = 3, TaskContent = "Alice Task 7",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 1) },

                new () { Id = 15, Name = "Impl Task 15", Difficulty = 2, TaskContent = "Carol Task 1",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 3) },
                new () { Id = 17, Name = "Impl Task 17", Difficulty = 5, TaskContent = "Carol Task 2",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 3) },
                new () { Id = 19, Name = "Impl Task 19", Difficulty = 3, TaskContent = "Carol Task 3",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 3) },
                new () { Id = 21, Name = "Impl Task 21", Difficulty = 3, TaskContent = "Carol Task 4",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 3) },
                new () { Id = 23, Name = "Impl Task 23", Difficulty = 2, TaskContent = "Carol Task 5",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 3) },
                new () { Id = 25, Name = "Impl Task 25", Difficulty = 5, TaskContent = "Carol Task 6",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 3) },
                new () { Id = 27, Name = "Impl Task 27", Difficulty = 3, TaskContent = "Carol Task 7",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 3) },

                new () { Id = 29, Name = "Impl Task 29", Difficulty = 2, TaskContent = "Eve Task 1",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 5) },
                new () { Id = 31, Name = "Impl Task 31", Difficulty = 5, TaskContent = "Eve Task 2",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 5) },
                new () { Id = 33, Name = "Impl Task 33", Difficulty = 3, TaskContent = "Eve Task 3",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 5) },
                new () { Id = 35, Name = "Impl Task 35", Difficulty = 3, TaskContent = "Eve Task 4",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 5) },
                new () { Id = 37, Name = "Impl Task 37", Difficulty = 2, TaskContent = "Eve Task 5",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 5) },
                new () { Id = 39, Name = "Impl Task 39", Difficulty = 3, TaskContent = "Eve Task 6",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 5) },

                new () { Id = 41, Name = "Impl Task 41", Difficulty = 2, TaskContent = "Grace Task 1",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 7) },
                new () { Id = 43, Name = "Impl Task 43", Difficulty = 5, TaskContent = "Grace Task 2",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 7) },
                new () { Id = 45, Name = "Impl Task 45", Difficulty = 3, TaskContent = "Grace Task 3",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 7) },
                new () { Id = 47, Name = "Impl Task 47", Difficulty = 3, TaskContent = "Grace Task 4",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 7) },
                new () { Id = 49, Name = "Impl Task 49", Difficulty = 2, TaskContent = "Grace Task 5",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 7) },
                new () { Id = 51, Name = "Impl Task 51", Difficulty = 3, TaskContent = "Grace Task 6",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 7) },

                new () { Id = 53, Name = "Impl Task 53", Difficulty = 2, TaskContent = "Ivan Task 1",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 9) },
                new () { Id = 55, Name = "Impl Task 55", Difficulty = 5, TaskContent = "Ivan Task 2",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 9) },
                new () { Id = 57, Name = "Impl Task 57", Difficulty = 3, TaskContent = "Ivan Task 3",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 9) },
                new () { Id = 59, Name = "Impl Task 59", Difficulty = 3, TaskContent = "Ivan Task 4",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 9) },
                new () { Id = 61, Name = "Impl Task 61", Difficulty = 2, TaskContent = "Ivan Task 5",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 9) },
                new () { Id = 63, Name = "Impl Task 63", Difficulty = 3, TaskContent = "Ivan Task 6",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 9) },

                new () { Id = 65, Name = "Impl Task 65", Difficulty = 2, TaskContent = "Mallory Task 1",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 11) },
                new () { Id = 67, Name = "Impl Task 67", Difficulty = 5, TaskContent = "Mallory Task 2",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 11) },
                new () { Id = 69, Name = "Impl Task 69", Difficulty = 3, TaskContent = "Mallory Task 3",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 11) },
                new () { Id = 71, Name = "Impl Task 71", Difficulty = 3, TaskContent = "Mallory Task 4",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 11) },
                new () { Id = 73, Name = "Impl Task 73", Difficulty = 2, TaskContent = "Mallory Task 5",  Status = Status.ToDo,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 11) },
                new () { Id = 75, Name = "Impl Task 75", Difficulty = 3, TaskContent = "Mallory Task 6",  Status = Status.Done,  TaskType = TaskTypes[2], User = Users.First(u => u.Id == 11) },

                new () { Id = 77, Name = "Impl Task 77", Difficulty = 3, TaskContent = "Unassigned Impl Task 1", Status = Status.ToDo,  TaskType = TaskTypes[2], User = null },
                new () { Id = 79, Name = "Impl Task 79", Difficulty = 5, TaskContent = "Unassigned Impl Task 2", Status = Status.ToDo,  TaskType = TaskTypes[2], User = null },
                new () { Id = 81, Name = "Impl Task 81", Difficulty = 2, TaskContent = "Unassigned Impl Task 3", Status = Status.ToDo,  TaskType = TaskTypes[2], User = null },
                new () { Id = 83, Name = "Impl Task 83", Difficulty = 3, TaskContent = "Unassigned Impl Task 4", Status = Status.ToDo,  TaskType = TaskTypes[2], User = null },
                new () { Id = 85, Name = "Impl Task 85", Difficulty = 3, TaskContent = "Unassigned Impl Task 5", Status = Status.ToDo,  TaskType = TaskTypes[2], User = null },
                new () { Id = 87, Name = "Impl Task 87", Difficulty = 2, TaskContent = "Unassigned Impl Task 6", Status = Status.ToDo,  TaskType = TaskTypes[2], User = null },
                new () { Id = 89, Name = "Impl Task 89", Difficulty = 5, TaskContent = "Unassigned Impl Task 7", Status = Status.ToDo,  TaskType = TaskTypes[2], User = null },
                new () { Id = 91, Name = "Impl Task 91", Difficulty = 3, TaskContent = "Unassigned Impl Task 8", Status = Status.ToDo,  TaskType = TaskTypes[2], User = null }
            ];

            Tasks = [.. DeploymentTasks, .. MaintenanceTasks, .. ImplementationTasks];
        }
    }
}
