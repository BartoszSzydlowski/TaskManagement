using TaskManagement.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace TaskManagement.Domain.Interfaces
{
    public interface IDeploymentTaskRepository
    {
        Task<List<DeploymentTask>> GetAll();

        Task<DeploymentTask> Get(int id);

        Task Add(DeploymentTask task);

        Task Update(DeploymentTask task);

        Task Delete(int id);
    }
}
