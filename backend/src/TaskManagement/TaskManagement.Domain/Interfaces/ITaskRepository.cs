namespace TaskManagement.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<Models.Task>> GetSortedByDifficultyDesc(int? userId, bool assigned = false);
    }
}