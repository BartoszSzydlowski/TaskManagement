using TaskManagement.Domain.Interfaces;
using TaskManagement.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskManagement.Infrastructure.Repository
{
    public class TaskTypeRepository(MockedData data) : ITaskTypeRepository
    {
        private readonly MockedData _data = data;

        public async Task<List<TaskType>> GetAll()
        {
            return await Task.FromResult(_data.TaskTypes);
        }
    }
}
