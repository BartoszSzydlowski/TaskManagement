using TaskManagement.Domain.Interfaces;
using TaskManagement.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskManagement.Infrastructure.Repository
{
    public class UserRepository(MockedData mockedData) : IUserRepository
    {
        private readonly MockedData _mockedData = mockedData;

        public async Task<List<User>> GetAll()
        {
            return await Task.FromResult(_mockedData.Users);
        }
    }
}
