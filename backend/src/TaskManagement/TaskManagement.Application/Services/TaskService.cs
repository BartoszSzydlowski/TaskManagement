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

        public async Task<PagedResponse<TaskViewModel>> GetSortedByDifficultyDesc(int? userId, int pageNumber, int pageSize)
        {
            var data = await _repository.GetSortedByDifficultyDesc(userId, pageNumber, pageSize);
            var count = await _repository.GetTotalCount(userId);

            return new PagedResponse<TaskViewModel>
            {
                Data = _mapper.Map<List<TaskViewModel>>(data),
                TotalCount = count,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}