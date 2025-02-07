namespace TaskManagement.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<Models.Task>> GetAll();

        Task<Models.Task> Get(int id);

        Task Add(Models.Task task);

        Task Update(Models.Task task);

        Task Delete(int id);
    }
}
