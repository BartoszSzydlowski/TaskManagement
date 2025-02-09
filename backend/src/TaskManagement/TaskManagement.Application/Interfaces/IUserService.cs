using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.ViewModels.User;

namespace TaskManagement.Application.Interfaces
{
    public interface IUserService
    {
        Task<ListResponse<UserViewModel>> GetAll();
    }
}