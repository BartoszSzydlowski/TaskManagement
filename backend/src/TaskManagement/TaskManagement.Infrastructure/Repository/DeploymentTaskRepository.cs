using TaskManagement.Domain.Interfaces;
using TaskManagement.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskManagement.Infrastructure.Repository
{
    public class DeploymentTaskRepository(MockedData data) : IDeploymentTaskRepository
    {
        private readonly MockedData _data = data;

        public Task<List<DeploymentTask>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DeploymentTask> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(DeploymentTask task)
        {
            throw new NotImplementedException();
        }

        public Task Update(DeploymentTask task)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
