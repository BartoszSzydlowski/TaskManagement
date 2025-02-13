using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.ViewModels.TaskTypeViewModel;

namespace TaskManagement.Application.Interfaces
{
    public interface ITaskTypeService
    {
        Task<ListResponse<TaskTypeViewModel>> GetAll();
    }
}
