using TaskManagement.Domain.Enums;
using Task = System.Threading.Tasks.Task;

namespace TaskManagement.Domain.Interfaces
{
    public interface ITaskRepository<T> where T : Models.Task
    {
        Task<int> GetTotalCount(int taskTypeId, int? userId, Status? status);

        Task<List<T>> GetFilteredByTaskTypeAndSortedByDifficultyDesc(int pageNumber, int pageSize, Status? status, int taskTypeId, int? userId);

        Task AddTaskToUser(int[] tasksIds, int userId);

        Task<T> Get(int id);

        Task<List<T>> GetUserTasks(int userId);
    }
}
