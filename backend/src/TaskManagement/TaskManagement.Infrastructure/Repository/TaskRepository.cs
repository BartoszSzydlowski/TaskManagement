using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Infrastructure.Repository
{
    public class TaskRepository(MockedData data) : ITaskRepository
    {
        private readonly MockedData _data = data;

        public async Task<List<Domain.Models.Task>> GetSortedByDifficultyDesc(int? userId, int pageNumber, int pageSize = 10)
        {
            var result = _data.Tasks
                .Where(x => userId == null ? x.User == null : x.User != null && x.User.Id == userId)
                .OrderByDescending(x => x.Difficulty)
                .Skip((pageNumber - 1) * pageSize) // Skip items from previous pages
                .Take(pageSize) // Take only the required number of items
                .ToList();
            return await Task.FromResult(result);
        }
    }
}