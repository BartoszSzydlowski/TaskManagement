using TaskManagement.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskManagement.Domain.Interfaces
{
    public interface ITaskRepository<T> where T : Models.Task
    {
        Task<int> GetTotalCount(int taskTypeId, int? userId);

        Task<List<T>> GetFilteredByTaskTypeAndSortedByDifficultyDesc(int pageNumber, int pageSize, int taskTypeId, int? userId);

        Task AddTaskToUser(int[] tasksIds, int userId);

        Task<T> Get(int id);
    }
}
