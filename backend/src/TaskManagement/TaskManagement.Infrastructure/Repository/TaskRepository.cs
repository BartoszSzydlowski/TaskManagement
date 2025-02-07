using System;
using System.Collections.Generic;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Infrastructure.Repository
{
    public class TaskRepository(MockedData data) : ITaskRepository
    {
        private readonly MockedData _data = data;

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
