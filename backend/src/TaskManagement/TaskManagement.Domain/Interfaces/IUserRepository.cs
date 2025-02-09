using TaskManagement.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskManagement.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();

        Task<User> Get(int id);

        Task Add(User task);

        Task Update(User task);

        Task Delete(int id);
    }
}
