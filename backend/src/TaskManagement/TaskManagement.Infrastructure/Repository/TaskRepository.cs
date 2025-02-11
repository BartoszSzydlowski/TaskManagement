using TaskManagement.Domain.Enums;
using TaskManagement.Domain.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace TaskManagement.Infrastructure.Repository
{
    public class TaskRepository<T>(MockedData data) : ITaskRepository<T>
        where T : Domain.Models.Task
    {
        private readonly MockedData _data = data;

        public async Task<int> GetTotalCount(int taskTypeId, int? userId, Status status)
        {
            return await Task.FromResult(
                _data.Tasks
                    .Where(x => (userId == null ? x.User == null : x.User != null && x.User.Id == userId) 
                        && taskTypeId == x.TaskType.Id
                        && status == x.Status)
                    .OrderByDescending(x => x.Difficulty)
                    .Count()
                );
        }

        public async Task<List<T>> GetFilteredByTaskTypeAndSortedByDifficultyDesc(int pageNumber, int pageSize, Status status, int taskTypeId, int? userId)
        {
            var result = _data.Tasks
                .Where(x => (userId == null ? x.User == null : x.User != null && x.User.Id == userId) 
                    && taskTypeId == x.TaskType.Id
                    && status == x.Status)
                .OrderByDescending(x => x.Difficulty);

            var pagedResult = result
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Cast<T>()
                .ToList();

            return await Task.FromResult(pagedResult);
        }

        public async Task AddTaskToUser(int[] tasksIds, int userId)
        {
            var user = _data.Users.Where(x => x.Id == userId).FirstOrDefault();
            var tasks = _data.Tasks.Where(x => tasksIds.Contains(x.Id)).ToList();
            await Task.Run(() =>
            {
                foreach (var task in tasks)
                {
                    task.User = user;
                }
            });
        }

        public async Task<T> Get(int id)
        {
            var result = await Task.FromResult(_data.Tasks.FirstOrDefault(x => x.Id == id) as T);
            return await Task.FromResult(result!);
        }

        public async Task<List<T>> GetUserTasks(int userId)
        {
            var result = _data.Tasks.Where(x => x.User?.Id == userId).Cast<T>().ToList();
            return await Task.FromResult(result!);
        }
    }
}
