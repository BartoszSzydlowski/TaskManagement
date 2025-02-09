using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Infrastructure.Repository
{
    public class TaskRepository<T>(MockedData data) : ITaskRepository<T> where T : Domain.Models.Task
    {
        private readonly MockedData _data = data;

        public async Task<int> GetTotalCount(int taskTypeId, int? userId)
        {
            return await Task.FromResult(
                _data.Tasks
                    .Where(x => (userId == null ? x.User == null : x.User != null && x.User.Id == userId) && taskTypeId == x.TaskType.Id)
                    .OrderByDescending(x => x.Difficulty)
                    .Count()
                );
        }

        public async Task<List<T>> GetFilteredByTaskTypeAndSortedByDifficultyDesc(int pageNumber, int pageSize, int taskTypeId, int? userId)
        {
            var result = _data.Tasks
                .Where(x => (userId == null ? x.User == null : x.User != null && x.User.Id == userId) && taskTypeId == x.TaskType.Id)
                .OrderByDescending(x => x.Difficulty);

            var pagedResult = result
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Cast<T>()
                .ToList();

            return await Task.FromResult(pagedResult);
        }
    }
}
