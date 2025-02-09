using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Infrastructure.Repository
{
    public class TaskRepository(MockedData data) : ITaskRepository
    {
        private readonly MockedData _data = data;

        public async Task<int> GetTotalCount(int? userId)
        {
            return await Task.FromResult(
                _data.Tasks
                    .Where(x => userId == null ? x.User == null : x.User != null && x.User.Id == userId)
                    .OrderByDescending(x => x.Difficulty)
                    .Count()
                );
        }

        public async Task<List<Domain.Models.Task>> GetSortedByDifficultyDesc(int? userId, int pageNumber, int pageSize)
        {
            var result = _data.Tasks
                .Where(x => userId == null ? x.User == null : x.User != null && x.User.Id == userId)
                .OrderByDescending(x => x.Difficulty);

            var pagedResult = result
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return await Task.FromResult(pagedResult);
        }
    }
}