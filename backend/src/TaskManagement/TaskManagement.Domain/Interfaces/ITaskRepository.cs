namespace TaskManagement.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<Models.Task>> GetSortedByDifficultyDesc(int? userId, int pageNumber, int pageSize);

        Task<int> GetTotalCount(int? userId);
    }
}