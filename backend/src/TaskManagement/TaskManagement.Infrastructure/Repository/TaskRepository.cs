using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Infrastructure.Repository
{
    public class TaskRepository(MockedData data) : ITaskRepository
    {
        private readonly MockedData _data = data;

        public async Task<List<Domain.Models.Task>> GetSortedByDifficultyDesc(int? userId)
        {
            var result = _data.Tasks
                .Where(x => userId == null ? x.User == null : x.User != null && x.User.Id == userId)
                .OrderByDescending(x => x.Difficulty)
                .ToList();
            return await Task.FromResult(result);
        }
    }
}