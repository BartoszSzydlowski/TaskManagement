using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.ViewModels.TaskViewModel;

namespace TaskManagement.Application.Interfaces
{
    public interface ITaskService
    {
        Task<ListResponse<TaskViewModel>> GetSortedByDifficultyDesc(int? userId);
    }
}