using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.ViewModels.TaskViewModel;

namespace TaskManagement.Application.Interfaces
{
    public interface ITaskService
    {
        Task<PagedResponse<TaskViewModel>> GetSortedByDifficultyDesc(int? userId, int pageNumber, int pageSize);
    }
}