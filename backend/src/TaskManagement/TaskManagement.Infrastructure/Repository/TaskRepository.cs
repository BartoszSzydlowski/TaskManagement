using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Infrastructure.Repository
{
    public class TaskRepository(MockedData data) : ITaskRepository
    {
        private readonly MockedData _data = data;

        public async Task<List<Domain.Models.Task>> GetSortedByDifficultyDesc(int? userId, bool assigned = false)
        {
            var result = _data.Tasks.Where(x => userId != null ? x.User?.Id == userId : x.User == null).ToList();
            return await Task.FromResult(result);
        }
    }
}