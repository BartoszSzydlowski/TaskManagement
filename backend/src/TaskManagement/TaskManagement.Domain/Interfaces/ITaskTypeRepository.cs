using TaskManagement.Domain.Models;

namespace TaskManagement.Domain.Interfaces
{
    public interface ITaskTypeRepository
    {
        Task<List<TaskType>> GetAll();
    }
}
