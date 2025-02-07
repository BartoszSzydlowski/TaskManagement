using System;
using System.Collections.Generic;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Infrastructure.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly List<Domain.Models.Task> _tasks;

        public TaskRepository()
        {
            _tasks =
            [
                new() { Id = 1, Difficulty = 1, TaskType = { Id = 1, TaskName = "Wdrożenie" }, Text = "Text" }
            ];
        }

        public Task<List<Domain.Models.Task>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Models.Task> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Domain.Models.Task task)
        {
            throw new NotImplementedException();
        }

        public Task Update(Domain.Models.Task task)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
