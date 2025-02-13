using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Requests;
using TaskManagement.Application.ViewModels.Task;
using TaskManagement.Domain.Enums;

namespace TaskManagement.Application.Interfaces
{
    public interface ITaskService<T>
        where T : TaskViewModel
    {
        Task<ListResponse<T>> GetFilteredByTaskTypeAndSortedByDifficultyDesc(Status? status, int taskTypeId, int? userId);

        Task<BaseResponse> AddTaskToUser(AddTaskToUserRequest request);

        Task<Domain.Models.Task> Get(int id);
    }
}
