using AutoMapper;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.ViewModels.TaskViewModel;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class TaskService(ITaskRepository repository, IMapper mapper) : ITaskService
    {
        private readonly ITaskRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<ListResponse<TaskViewModel>> GetSortedByDifficultyDesc(int? userId)
        {
            var data = await _repository.GetSortedByDifficultyDesc(userId);
            return new ListResponse<TaskViewModel>
            {
                Data = _mapper.Map<List<TaskViewModel>>(data),
                Total = data.Count
            };
        }
    }
}