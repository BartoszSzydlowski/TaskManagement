using TaskManagement.Domain.Models;

namespace TaskManagement.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
    }
}