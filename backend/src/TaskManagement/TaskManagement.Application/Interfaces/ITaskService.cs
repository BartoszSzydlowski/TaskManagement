using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.ViewModels.TaskViewModel;

namespace TaskManagement.Application.Interfaces
{
    public interface ITaskService<T> where T : TaskViewModel
    {
        Task<PagedResponse<T>> GetFilteredByTaskTypeAndSortedByDifficultyDesc(int pageNumber, int pageSize, int taskTypeId, int? userId);
    }
}